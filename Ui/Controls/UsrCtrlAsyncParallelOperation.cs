using System.Data;
using System.Diagnostics;
using Ui.Services;

namespace Ui.Controls
{
    public partial class UsrCtrlAsyncParallelOperation : UserControl
    {
        public UsrCtrlAsyncParallelOperation()
        {
            InitializeComponent();
        }

        Stopwatch mainWatch = new Stopwatch();
        bool isT1, isT2, isT3, isT4;
        private void btnExecuteAsyncProcess_Click(object sender, EventArgs e)
        {
            mainWatch.Start();

            lbOperationResult.Items.Clear();
            dgvAllRecords.DataSource = null;
            dgvAllRecords.Rows.Clear();
            dgvMale.DataSource = null;
            dgvMale.Rows.Clear();
            dgvFemale.DataSource = null;
            dgvFemale.Rows.Clear();
            dgvMostCommon.DataSource = null;
            dgvMostCommon.Rows.Clear();
            lblOperationTime.Text = "Total Time: ";
            isT1 = isT2 = isT3 = isT4 = false;

            lbOperationResult.Items.Add($"Parallel operation started. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

            Task.Run(async () => { await PopulateAllRecordsAsync(); });
            Task.Run(async () => { await PopulateMaleRecordsAsync(); });
            Task.Run(async () => { await PopulateFemaleRecordsAsync(); });
            Task.Run(async () => { await PopulateCommonRecordsAsync(); });
        }

        public async Task PopulateAllRecordsAsync()
        {
            UpdateProcessListView($"Operation Started to fetch all records. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

            var watch = new Stopwatch();
            watch.Start();

            var service = new AsynchronousOperationService();
            var records = await service.ListAllAsync();
            UpdateProcessListView($"All Records Listed from db. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

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

            UpdateProcessListView($"All records populating in [All Records Datagrid View]. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            this.Invoke(new MethodInvoker(() =>
            {
                dgvAllRecords.DataSource = dataTable;

                watch.Stop();

                lblAllRecords.Text = $"All Records ({records.Count:n0}) - {watch.ElapsedMilliseconds:n0} ms";
            }));

            UpdateProcessListView($"All records operation completed. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            isT1 = true;
            CompeleteWatch();
        }

        public async Task PopulateMaleRecordsAsync()
        {
            UpdateProcessListView($"Operation Started to fetch male records. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

            var watch = new Stopwatch();
            watch.Start();

            var service = new AsynchronousOperationService();
            var records = await service.ListMaleAsync();

            UpdateProcessListView($"Male Records Listed from db. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Year", typeof(int));
            dataTable.Columns.Add("Count", typeof(int));

            foreach (var record in records)
            {
                dataTable.Rows.Add(record.Id, record.Name, record.Year, record.Count);
            }

            UpdateProcessListView($"Male records populating in [All Male Records Datagrid View]. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            this.Invoke(new MethodInvoker(() =>
            {
                dgvMale.DataSource = dataTable;

                watch.Stop();

                lblAllMaleRecords.Text = $"All Male Records ({records.Count:n0}) - {watch.ElapsedMilliseconds:n0} ms";
            }));

            UpdateProcessListView($"Male records operation completed. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            isT2 = true;
            CompeleteWatch();
        }

        public async Task PopulateFemaleRecordsAsync()
        {
            UpdateProcessListView($"Operation Started to fetch female records. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            var watch = new Stopwatch();
            watch.Start();

            var service = new AsynchronousOperationService();
            var records = await service.ListFemaleAsync();
            UpdateProcessListView($"Female Records Listed from db. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Year", typeof(int));
            dataTable.Columns.Add("Count", typeof(int));

            foreach (var record in records)
            {
                dataTable.Rows.Add(record.Id, record.Name, record.Year, record.Count);
            }

            UpdateProcessListView($"Female records populating in [All Female Records Datagrid View]. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            this.Invoke(new MethodInvoker(() =>
            {
                dgvFemale.DataSource = dataTable;

                dgvFemale.Columns[0].Width = 75;
                dgvFemale.Columns[1].Width = 175;
                dgvFemale.Columns[2].Width = 75;
                dgvFemale.Columns[3].Width = 75;

                watch.Stop();

                lblAllFemaleRecords.Text = $"All Female Records ({records.Count:n0}) - {watch.ElapsedMilliseconds:n0} ms";
            }));

            UpdateProcessListView($"Female records operation completed. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            isT3 = true;
            CompeleteWatch();
        }

        public async Task PopulateCommonRecordsAsync()
        {
            UpdateProcessListView($"Operation Started to fetch most common records. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            var watch = new Stopwatch();
            watch.Start();

            var service = new AsynchronousOperationService();
            var records = await service.ListMostCommonAsync();
            UpdateProcessListView($"Most Common Records Listed from db. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

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

            UpdateProcessListView($"Most common records populating in [Common Records Datagrid View]. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            this.Invoke(new MethodInvoker(() =>
            {
                dgvMostCommon.DataSource = dataTable;

                watch.Stop();
                lblCommonRecords.Text = $"Common Records (Top 100) - {watch.ElapsedMilliseconds:n0} ms";
            }));

            UpdateProcessListView($"Most common records operation completed. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            isT4 = true;
            CompeleteWatch();
        }

        private void UpdateProcessListView(string message)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                lbOperationResult.Items.Add(message);
            }));
        }

        private void CompeleteWatch()
        {
            if (isT1 && isT2 && isT3 && isT4)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    mainWatch.Stop();
                    lblOperationTime.Text = $"Total Time: {mainWatch.ElapsedMilliseconds:n0} ms";
                    lbOperationResult.Items.Add($"Parallel operation completed. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
                }));
            }
        }
    }
}
