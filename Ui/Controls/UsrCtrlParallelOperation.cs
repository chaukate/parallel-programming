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
            isT1 = isT2 = isT3 = isT4 = false;

            lbOperationResult.Items.Add($"Parallel operation starting. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

            switch (cbExecutionType.SelectedItem)
            {
                case "All Threads":
                    AllThreads();
                    break;
                case "All Tasks":
                    AllTasks();
                    break;
                case "Two Threads Two Tasks":
                    TwoThreadsTwoTasks();
                    break;
                default:
                    MessageBox.Show("Invalid request. Please select execution type.");
                    lbOperationResult.Items.Clear();
                    break;
            }
        }

        private void AllThreads()
        {
            new Thread(new ThreadStart(PopulateAllRecords)).Start();
            new Thread(new ThreadStart(PopulateMaleRecords)).Start();
            new Thread(new ThreadStart(PopulateFemaleRecords)).Start();
            new Thread(new ThreadStart(PopulateCommonRecords)).Start();
        }

        private void TwoThreadsTwoTasks()
        {
            new Thread(new ThreadStart(() =>
            {
                Task.Run(() => PopulateAllRecords());
                Task.Run(() => PopulateMaleRecords());
            })).Start();

            new Thread(new ThreadStart(() =>
            {
                Task.Run(() => PopulateFemaleRecords());
                Task.Run(() => PopulateCommonRecords());
            })).Start();
        }

        private void AllTasks()
        {
            Task.Run(() => PopulateAllRecords());
            Task.Run(() => PopulateMaleRecords());
            Task.Run(() => PopulateFemaleRecords());
            Task.Run(() => PopulateCommonRecords());
        }

        public void PopulateAllRecords()
        {
            UpdateProcessListView($"Operation Started to fetch all records. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

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

        public void PopulateMaleRecords()
        {
            UpdateProcessListView($"Operation Started to fetch male records. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");

            var watch = new Stopwatch();
            watch.Start();

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

        public void PopulateFemaleRecords()
        {
            UpdateProcessListView($"Operation Started to fetch female records. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            var watch = new Stopwatch();
            watch.Start();

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

        public void PopulateCommonRecords()
        {
            UpdateProcessListView($"Operation Started to fetch most common records. [{DateTime.Now:MMM dd, yyyy HH:mm:ss}]");
            var watch = new Stopwatch();
            watch.Start();

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
