namespace Ui.Controls
{
    public partial class UsrCtrlSyncOperation : UserControl
    {
        public UsrCtrlSyncOperation()
        {
            InitializeComponent();
        }

        private void btnAllRecords_Click(object sender, EventArgs e)
        {
            usrCtrlSync.PopulateAllRecords();
        }

        private void btnAllMaleRecords_Click(object sender, EventArgs e)
        {
            usrCtrlSync.PopulateMaleRecords();
        }

        private void btnAllFemaleRecords_Click(object sender, EventArgs e)
        {
            usrCtrlSync.PopulateFemaleRecords();
        }

        private void btnMostCommonRecords_Click(object sender, EventArgs e)
        {
            usrCtrlSync.PopulateCommonRecords();
        }

        UsrCtrlSyncListAll usrCtrlSync = new UsrCtrlSyncListAll();
        private void UsrCtrlSyncOperation_Load(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Add(usrCtrlSync);
            usrCtrlSync.Dock = DockStyle.Fill;
        }
    }
}
