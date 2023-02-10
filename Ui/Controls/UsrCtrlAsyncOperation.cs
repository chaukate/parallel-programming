namespace Ui.Controls
{
    public partial class UsrCtrlAsyncOperation : UserControl
    {
        public UsrCtrlAsyncOperation()
        {
            InitializeComponent();
        }

        private void btnAllRecords_Click(object sender, EventArgs e)
        {
            usrCtrlAsync.PopulateAllRecords();
        }

        private void btnAllMaleRecords_Click(object sender, EventArgs e)
        {
            usrCtrlAsync.PopulateMaleRecords();
        }

        private void btnAllFemaleRecords_Click(object sender, EventArgs e)
        {
            usrCtrlAsync.PopulateFemaleRecords();
        }

        private void btnMostCommonRecords_Click(object sender, EventArgs e)
        {
            usrCtrlAsync.PopulateCommonRecords();
        }

        UsrCtrlAsyncListAll usrCtrlAsync = new UsrCtrlAsyncListAll();
        private void UsrCtrlAsyncOperation_Load(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Add(usrCtrlAsync);
            usrCtrlAsync.Dock = DockStyle.Fill;
        }
    }
}
