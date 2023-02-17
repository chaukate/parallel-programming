using System.Data;
using System.Diagnostics;
using Ui.Services;

namespace Ui.Controls
{
    public partial class UsrCtrlParallelOperation : UserControl
    {
        public UsrCtrlParallelOperation()
        {
            InitializeComponent();
        }

        Stopwatch mainWatch = new Stopwatch();
        bool isT1, isT2, isT3, isT4;
        private void btnExecuteProcess_Click(object sender, EventArgs e)
        {
            mainWatch = new Stopwatch();
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
            lblAllRecords.Text = $"All Records (0)";
            lblAllMaleRecords.Text = $"Male Records (0)";
            lblAllFemaleRecords.Text = $"Female Records (0)";
            lblCommonRecords.Text = $"Common Records (0)";
            var take = (int)numericValue.Value;

            isT1 = isT2 = isT3 = isT4 = false;

            lbOperationResult.Items.Add($"Parallel operation starting. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

            switch (cbExecutionType.SelectedItem)
            {
                case "All Threads":
                    AllThreads(take);
                    break;
                case "All Tasks":
                    AllTasks(take);
                    break;
                case "Two Threads Two Tasks":
                    TwoThreadsTwoTasks(take);
                    break;
                case "Synchronous":
                    Synchronous(take);
                    break;
                default:
                    MessageBox.Show("Invalid request. Please select execution type.");
                    lbOperationResult.Items.Clear();
                    break;
            }
        }

        private void AllThreads(int take)
        {
            var t1 = new Thread(async () => { await PopulateAllRecords(take); });
            var t2 = new Thread(async () => { await PopulateMaleRecords(take); });
            var t3 = new Thread(async () => { await PopulateFemaleRecords(take); });
            var t4 = new Thread(async () => { await PopulateCommonRecords(take); });

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
        }

        private void TwoThreadsTwoTasks(int take)
        {
            new Thread(new ThreadStart(() =>
            {
                Task.Run(() => PopulateAllRecords(take));
                Task.Run(() => PopulateMaleRecords(take));
            })).Start();

            new Thread(new ThreadStart(() =>
            {
                Task.Run(() => PopulateFemaleRecords(take));
                Task.Run(() => PopulateCommonRecords(take));
            })).Start();
        }

        private void AllTasks(int take)
        {
            Task.Run(() => PopulateAllRecords(take));
            Task.Run(() => PopulateMaleRecords(take));
            Task.Run(() => PopulateFemaleRecords(take));
            Task.Run(() => PopulateCommonRecords(take));
        }

        public async Task PopulateAllRecords(int take)
        {
            var watch = new Stopwatch();
            watch.Start();

            UpdateProcessListView($"Operation Started to fetch all records. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            var service = new AsynchronousOperationService();
            var records = await service.ListAllAsync(take);
            UpdateProcessListView($"All records fetched in {watch.ElapsedMilliseconds:n0} ms. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

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

            UpdateProcessListView($"All records populating in DataTable. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            this.Invoke(new MethodInvoker(() =>
            {
                _dtAll = dataTable;
                if (take < 1000)
                {
                    dgvAllRecords.DataSource = dataTable;
                }
                watch.Stop();
                lblAllRecords.Text = $"All Records ({records.Count:n0}) - {watch.ElapsedMilliseconds:n0} ms";
            }));

            UpdateProcessListView($"All records operation completed. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            isT1 = true;
            CompeleteWatch();
        }

        public async Task PopulateMaleRecords(int take)
        {
            var watch = new Stopwatch();
            watch.Start();

            UpdateProcessListView($"Operation Started to fetch male records. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            var service = new AsynchronousOperationService();
            var records = await service.ListMaleAsync(take);
            UpdateProcessListView($"Male records fetched in {watch.ElapsedMilliseconds:n0} ms. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Year", typeof(int));
            dataTable.Columns.Add("Count", typeof(int));

            UpdateProcessListView($"Male records populating in DataTable. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            foreach (var record in records)
            {
                dataTable.Rows.Add(record.Id, record.Name, record.Year, record.Count);
            }

            this.Invoke(new MethodInvoker(() =>
            {
                _dtMale = dataTable;
                if (take < 1000)
                {
                    dgvMale.DataSource = dataTable;
                }
                watch.Stop();
                lblAllMaleRecords.Text = $"All Male Records ({records.Count:n0}) - {watch.ElapsedMilliseconds:n0} ms";
            }));

            UpdateProcessListView($"Male records operation completed. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            isT2 = true;
            CompeleteWatch();
        }

        public async Task PopulateFemaleRecords(int take)
        {
            var watch = new Stopwatch();
            watch.Start();

            UpdateProcessListView($"Operation Started to fetch female records. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            var service = new AsynchronousOperationService();
            var records = await service.ListFemaleAsync(take);
            UpdateProcessListView($"Female records fetched in {watch.ElapsedMilliseconds:n0} ms. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Year", typeof(int));
            dataTable.Columns.Add("Count", typeof(int));

            UpdateProcessListView($"Female records populating in DataTable. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            foreach (var record in records)
            {
                dataTable.Rows.Add(record.Id, record.Name, record.Year, record.Count);
            }

            this.Invoke(new MethodInvoker(() =>
            {
                _dtFemale = dataTable;
                if (take < 1000)
                {
                    dgvFemale.DataSource = dataTable;
                }
                watch.Stop();
                lblAllFemaleRecords.Text = $"All Female Records ({records.Count:n0}) - {watch.ElapsedMilliseconds:n0} ms";
            }));

            UpdateProcessListView($"Female records operation completed. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            isT3 = true;
            CompeleteWatch();
        }

        public async Task PopulateCommonRecords(int take)
        {
            var watch = new Stopwatch();
            watch.Start();

            UpdateProcessListView($"Operation Started to fetch most common records. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            var service = new AsynchronousOperationService();
            var records = await service.ListMostCommonAsync(take);
            UpdateProcessListView($"Common records fetched in {watch.ElapsedMilliseconds:n0} ms. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Year", typeof(int));
            dataTable.Columns.Add("Gender", typeof(char));
            dataTable.Columns.Add("Count", typeof(int));

            UpdateProcessListView($"Most common records populating in DataTable. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            foreach (var record in records)
            {
                dataTable.Rows.Add(record.Id, record.Name, record.Year, record.Gender, record.Count);
            }

            this.Invoke(new MethodInvoker(() =>
            {
                _dtCommon = dataTable;
                if (take < 1000)
                {
                    dgvMostCommon.DataSource = dataTable;
                }
                watch.Stop();
                lblCommonRecords.Text = $"Common Records (Top {records.Count}) - {watch.ElapsedMilliseconds:n0} ms";
            }));

            UpdateProcessListView($"Most common records operation completed. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            isT4 = true;
            CompeleteWatch();
        }

        private DataTable _dtAll = new DataTable();
        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    dgvAllRecords.DataSource = _dtAll;
                }));
            });
        }

        private DataTable _dtFemale = new DataTable();
        private void btnLoadFemale_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    dgvFemale.DataSource = _dtFemale;

                    dgvFemale.Columns[0].Width = 75;
                    dgvFemale.Columns[1].Width = 175;
                    dgvFemale.Columns[2].Width = 75;
                    dgvFemale.Columns[3].Width = 75;
                }));
            });
        }

        private DataTable _dtMale = new DataTable();
        private void btnLoadMale_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    dgvMale.DataSource = _dtMale;
                }));
            });

        }

        private DataTable _dtCommon = new DataTable();
        private void btnLoadCommon_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    dgvMostCommon.DataSource = _dtCommon;
                }));
            });
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
            this.Invoke(new MethodInvoker(() =>
            {
                lblOperationTime.Text = $"Total Time: {mainWatch.ElapsedMilliseconds:n0} ms";
            }));

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

        #region Synchronous
        private void Synchronous(int take)
        {
            PopulateAll(take);
            PopulateMale(take);
            PopulateFemale(take);
            PopulateCommon(take);
        }

        private void PopulateAll(int take)
        {
            UpdateProcessListView($"Operation Started to fetch all records. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            var service = new AsynchronousOperationService();
            var records = service.ListAllAsync(take).Result;
            UpdateProcessListView($"All records fetched in {mainWatch.ElapsedMilliseconds:n0} ms. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

            isT1 = true;
            CompeleteWatch();

            UpdateProcessListView($"All records populating in DataTable. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
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

            UpdateProcessListView($"All records populating in DataTable. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

            _dtAll = dataTable;
            dgvAllRecords.DataSource = dataTable;
            lblAllRecords.Text = $"All Records ({records.Count:n0}) - {mainWatch.ElapsedMilliseconds:n0} ms";

            UpdateProcessListView($"All records operation completed. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
        }

        private void PopulateMale(int take)
        {
            UpdateProcessListView($"Operation Started to fetch male records. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            var service = new AsynchronousOperationService();
            var records = service.ListMaleAsync(take).Result;
            UpdateProcessListView($"Male records fetched in {mainWatch.ElapsedMilliseconds:n0} ms. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            isT2 = true;
            CompeleteWatch();

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Year", typeof(int));
            dataTable.Columns.Add("Count", typeof(int));

            foreach (var record in records)
            {
                dataTable.Rows.Add(record.Id, record.Name, record.Year, record.Count);
            }

            UpdateProcessListView($"Male records populating in DataTable. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

            _dtMale = dataTable;
            dgvMale.DataSource = dataTable;
            lblAllMaleRecords.Text = $"All Records ({records.Count:n0}) - {mainWatch.ElapsedMilliseconds:n0} ms";

            UpdateProcessListView($"Male records operation completed. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
        }

        private void PopulateFemale(int take)
        {
            UpdateProcessListView($"Operation Started to fetch female records. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            var service = new AsynchronousOperationService();
            var records = service.ListFemaleAsync(take).Result;
            UpdateProcessListView($"Female records fetched in {mainWatch.ElapsedMilliseconds:n0} ms. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            isT3 = true;
            CompeleteWatch();

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Year", typeof(int));
            dataTable.Columns.Add("Count", typeof(int));

            foreach (var record in records)
            {
                dataTable.Rows.Add(record.Id, record.Name, record.Year, record.Count);
            }

            UpdateProcessListView($"Female records populating in DataTable. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            _dtFemale = dataTable;
            dgvFemale.DataSource = dataTable;
            lblAllFemaleRecords.Text = $"All Female Records ({records.Count:n0}) - {mainWatch.ElapsedMilliseconds:n0} ms";

            UpdateProcessListView($"Female records operation completed. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
        }

        private void PopulateCommon(int take)
        {
            UpdateProcessListView($"Operation Started to fetch most common records. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            var service = new AsynchronousOperationService();
            var records = service.ListMostCommonAsync(take).Result;
            UpdateProcessListView($"Common records fetched in {mainWatch.ElapsedMilliseconds:n0} ms. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            isT4 = true;
            CompeleteWatch();

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

            UpdateProcessListView($"Most common records populating in DataTable. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            _dtCommon = dataTable;
            dgvMostCommon.DataSource = dataTable;
            lblCommonRecords.Text = $"Common Records (Top 100) - {mainWatch.ElapsedMilliseconds:n0} ms";

            UpdateProcessListView($"Most common records operation completed. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
        }
        #endregion
    }
}
