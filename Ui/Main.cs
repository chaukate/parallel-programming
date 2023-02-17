using Ui.Controls;
using Ui.Helpers;

namespace Ui
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnSOAction_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            var usrCtrl = new UsrCtrlSyncOperation();
            usrCtrl.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(usrCtrl);
        }

        private void btnAOAction_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            var usrCtrl = new UsrCtrlAsyncOperation();
            usrCtrl.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(usrCtrl);
        }

        int totalInserted = 0;
        private void Main_Load(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                var records = await FileHelper.ReadRecordsAsync();

                var batchSize = 5000;
                var batchCount = (records.Count / batchSize);

                FileHelper.CreateDbInstance();
                for (int i = 0; i <= batchCount; i++)
                {
                    var recordsToInsert = records.Skip(batchSize * i).Take(batchSize);
                    var result = await FileHelper.WriteRecordsAsync(recordsToInsert.ToList());

                    totalInserted += result;
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        lblRecords.Text = $"Records: {totalInserted:n0}";
                    }));
                }

                lblRecords.Text = $"Records: {totalInserted:n0}";
            });
        }

        private void btnPOAction_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            var usrCtrl = new UsrCtrlParallelOperation();
            usrCtrl.numericValue.Minimum = 0;
            usrCtrl.numericValue.Maximum = totalInserted;
            usrCtrl.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(usrCtrl);
        }

        private void btnPAOAction_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            var usrCtrl = new UsrCtrlAsyncParallelOperation();
            usrCtrl.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(usrCtrl);
        }
    }
}
