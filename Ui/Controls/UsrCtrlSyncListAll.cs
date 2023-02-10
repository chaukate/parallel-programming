using System.Data;
using System.Diagnostics;
using Ui.Helpers;
using Ui.Services;

namespace Ui.Controls
{
    public partial class UsrCtrlSyncListAll : UserControl
    {
        public UsrCtrlSyncListAll()
        {
            InitializeComponent();
        }

        public void PopulateAllRecords()
        {
            var watch = new Stopwatch();
            watch.Start();

            var service = new SynchronousOperationService();
            var records = service.ListAll();

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Year", typeof(int));
            dataTable.Columns.Add("Gender", typeof(char));
            dataTable.Columns.Add("Count", typeof(int));

            foreach (var record in records)
            {
                dataTable.Rows.Add(record.Id, record.Name, record.Year, record.Gender, record.Count);
            }

            dgvAllRecords.DataSource = dataTable;

            watch.Stop();

            lblAllRecords.Text = $"All Records ({records.Count:n0}) - {watch.ElapsedMilliseconds:n0} ms";
        }

        public void PopulateMaleRecords()
        {
            var watch = new Stopwatch();
            watch.Start();

            FileHelper.CreateDbInstance();
            var service = new SynchronousOperationService();
            var records = service.ListMale();

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Year", typeof(int));
            dataTable.Columns.Add("Count", typeof(int));

            foreach (var record in records)
            {
                dataTable.Rows.Add(record.Id, record.Name, record.Year, record.Count);
            }

            dgvMale.DataSource = dataTable;

            watch.Stop();

            lblAllMaleRecords.Text = $"All Male Records ({records.Count:n0}) - {watch.ElapsedMilliseconds:n0} ms";
        }

        public void PopulateFemaleRecords()
        {
            var watch = new Stopwatch();
            watch.Start();

            FileHelper.CreateDbInstance();
            var service = new SynchronousOperationService();
            var records = service.ListFemale();

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Year", typeof(int));
            dataTable.Columns.Add("Count", typeof(int));

            foreach (var record in records)
            {
                dataTable.Rows.Add(record.Id, record.Name, record.Year, record.Count);
            }

            dgvFemale.DataSource = dataTable;

            dgvFemale.Columns[0].Width = 75;
            dgvFemale.Columns[1].Width = 175;
            dgvFemale.Columns[2].Width = 75;
            dgvFemale.Columns[3].Width = 75;

            watch.Stop();

            lblAllFemaleRecords.Text = $"All Female Records ({records.Count:n0}) - {watch.ElapsedMilliseconds:n0} ms";
        }

        public void PopulateCommonRecords()
        {
            var watch = new Stopwatch();
            watch.Start();

            FileHelper.CreateDbInstance();
            var service = new SynchronousOperationService();
            var records = service.ListMostCommon();

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Year", typeof(int));
            dataTable.Columns.Add("Gender", typeof(char));
            dataTable.Columns.Add("Count", typeof(int));

            foreach (var record in records)
            {
                dataTable.Rows.Add(record.Id, record.Name, record.Year, record.Gender, record.Count);
            }

            dgvMostCommon.DataSource = dataTable;

            watch.Stop();
            lblCommonRecords.Text = $"Common Records (Top 100) - {watch.ElapsedMilliseconds:n0} ms";
        }
    }
}
