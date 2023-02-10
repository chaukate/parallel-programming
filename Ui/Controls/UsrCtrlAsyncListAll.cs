using System.Data;
using System.Diagnostics;
using Ui.Services;

namespace Ui.Controls
{
    public partial class UsrCtrlAsyncListAll : UserControl
    {
        public UsrCtrlAsyncListAll()
        {
            InitializeComponent();
        }

        public void PopulateAllRecords()
        {
            var watch = new Stopwatch();
            watch.Start();
            dgvAllRecords.Cursor = Cursors.WaitCursor;

            Task.Run(async () =>
            {
                var service = new AsynchronousOperationService();
                var records = await service.ListAllAsync();

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

                this.Invoke(new MethodInvoker(delegate
                {
                    dgvAllRecords.DataSource = dataTable;
                    dgvAllRecords.Cursor = Cursors.Default;

                    watch.Stop();
                    lblAllRecords.Text = $"All Records ({records.Count:n0}) - {watch.ElapsedMilliseconds:n0} ms";
                }));
            });
        }

        public void PopulateMaleRecords()
        {
            var watch = new Stopwatch();
            watch.Start();
            dgvMale.Cursor = Cursors.WaitCursor;

            Task.Run(async () =>
            {
                var service = new AsynchronousOperationService();
                var records = await service.ListMaleAsync();

                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Name", typeof(string));
                dataTable.Columns.Add("Year", typeof(int));
                dataTable.Columns.Add("Count", typeof(int));

                foreach (var record in records)
                {
                    dataTable.Rows.Add(record.Id, record.Name, record.Year, record.Count);
                }

                this.Invoke(new MethodInvoker(() =>
                {
                    dgvMale.DataSource = dataTable;
                    dgvMale.Cursor = Cursors.Default;

                    watch.Stop();
                    lblAllMaleRecords.Text = $"All Male Records ({records.Count:n0}) - {watch.ElapsedMilliseconds:n0} ms";
                }));
            });
        }

        public void PopulateFemaleRecords()
        {
            var watch = new Stopwatch();
            dgvFemale.Cursor = Cursors.WaitCursor;
            watch.Start();

            Task.Run(async () =>
            {
                var service = new AsynchronousOperationService();
                var records = await service.ListFemaleAsync();

                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Name", typeof(string));
                dataTable.Columns.Add("Year", typeof(int));
                dataTable.Columns.Add("Count", typeof(int));

                foreach (var record in records)
                {
                    dataTable.Rows.Add(record.Id, record.Name, record.Year, record.Count);
                }

                this.Invoke(new MethodInvoker(() =>
                {
                    dgvFemale.DataSource = dataTable;

                    dgvFemale.Columns[0].Width = 75;
                    dgvFemale.Columns[1].Width = 175;
                    dgvFemale.Columns[2].Width = 75;
                    dgvFemale.Columns[3].Width = 75;

                    watch.Stop();
                    dgvFemale.Cursor = Cursors.Default;

                    watch.Stop();
                    lblAllFemaleRecords.Text = $"All Female Records ({records.Count:n0}) - {watch.ElapsedMilliseconds:n0} ms";
                }));
            });
        }

        public void PopulateCommonRecords()
        {
            var watch = new Stopwatch();
            dgvMostCommon.Cursor = Cursors.WaitCursor;
            watch.Start();

            Task.Run(async () =>
            {
                var service = new AsynchronousOperationService();
                var records = await service.ListMostCommonAsync();

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

                this.Invoke(new MethodInvoker(() =>
                {
                    dgvMostCommon.DataSource = dataTable;
                    dgvMostCommon.Cursor = Cursors.Default;

                    watch.Stop();
                    lblCommonRecords.Text = $"Common Records (Top 100) - {watch.ElapsedMilliseconds:n0} ms";
                }));
            });
        }
    }
}
