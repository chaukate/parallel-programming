namespace Ui.Controls
{
    partial class UsrCtrlParallelOperation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlCenterMain = new System.Windows.Forms.Panel();
            this.pnlLeftMain = new System.Windows.Forms.Panel();
            this.dgvFemale = new System.Windows.Forms.DataGridView();
            this.pnlTopMostCommon = new System.Windows.Forms.Panel();
            this.lblAllFemaleRecords = new System.Windows.Forms.Label();
            this.dgvAllRecords = new System.Windows.Forms.DataGridView();
            this.pnlTopAllRecords = new System.Windows.Forms.Panel();
            this.lblAllRecords = new System.Windows.Forms.Label();
            this.pnlRightMain = new System.Windows.Forms.Panel();
            this.dgvMostCommon = new System.Windows.Forms.DataGridView();
            this.pnlTopFemale = new System.Windows.Forms.Panel();
            this.lblCommonRecords = new System.Windows.Forms.Label();
            this.dgvMale = new System.Windows.Forms.DataGridView();
            this.pnlTopMale = new System.Windows.Forms.Panel();
            this.lblAllMaleRecords = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblOperationTime = new System.Windows.Forms.Label();
            this.lbOperationResult = new System.Windows.Forms.ListBox();
            this.btnExecuteProcess = new System.Windows.Forms.Button();
            this.cbExecutionType = new System.Windows.Forms.ComboBox();
            this.pnlListTop = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlLeftMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFemale)).BeginInit();
            this.pnlTopMostCommon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRecords)).BeginInit();
            this.pnlTopAllRecords.SuspendLayout();
            this.pnlRightMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostCommon)).BeginInit();
            this.pnlTopFemale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMale)).BeginInit();
            this.pnlTopMale.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlListTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlCenterMain);
            this.pnlMain.Controls.Add(this.pnlLeftMain);
            this.pnlMain.Controls.Add(this.pnlRightMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(384, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1103, 643);
            this.pnlMain.TabIndex = 3;
            // 
            // pnlCenterMain
            // 
            this.pnlCenterMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterMain.Location = new System.Drawing.Point(579, 0);
            this.pnlCenterMain.Name = "pnlCenterMain";
            this.pnlCenterMain.Size = new System.Drawing.Size(2, 643);
            this.pnlCenterMain.TabIndex = 5;
            // 
            // pnlLeftMain
            // 
            this.pnlLeftMain.Controls.Add(this.dgvFemale);
            this.pnlLeftMain.Controls.Add(this.pnlTopMostCommon);
            this.pnlLeftMain.Controls.Add(this.dgvAllRecords);
            this.pnlLeftMain.Controls.Add(this.pnlTopAllRecords);
            this.pnlLeftMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftMain.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftMain.Name = "pnlLeftMain";
            this.pnlLeftMain.Size = new System.Drawing.Size(579, 643);
            this.pnlLeftMain.TabIndex = 3;
            // 
            // dgvFemale
            // 
            this.dgvFemale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFemale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFemale.Location = new System.Drawing.Point(0, 372);
            this.dgvFemale.MultiSelect = false;
            this.dgvFemale.Name = "dgvFemale";
            this.dgvFemale.RowHeadersVisible = false;
            this.dgvFemale.RowTemplate.Height = 25;
            this.dgvFemale.Size = new System.Drawing.Size(579, 271);
            this.dgvFemale.TabIndex = 6;
            // 
            // pnlTopMostCommon
            // 
            this.pnlTopMostCommon.Controls.Add(this.lblAllFemaleRecords);
            this.pnlTopMostCommon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMostCommon.Location = new System.Drawing.Point(0, 322);
            this.pnlTopMostCommon.Name = "pnlTopMostCommon";
            this.pnlTopMostCommon.Size = new System.Drawing.Size(579, 50);
            this.pnlTopMostCommon.TabIndex = 3;
            // 
            // lblAllFemaleRecords
            // 
            this.lblAllFemaleRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAllFemaleRecords.Location = new System.Drawing.Point(3, 7);
            this.lblAllFemaleRecords.Name = "lblAllFemaleRecords";
            this.lblAllFemaleRecords.Size = new System.Drawing.Size(629, 37);
            this.lblAllFemaleRecords.TabIndex = 1;
            this.lblAllFemaleRecords.Text = "All Female Records";
            this.lblAllFemaleRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAllRecords
            // 
            this.dgvAllRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAllRecords.Location = new System.Drawing.Point(0, 50);
            this.dgvAllRecords.MultiSelect = false;
            this.dgvAllRecords.Name = "dgvAllRecords";
            this.dgvAllRecords.RowHeadersVisible = false;
            this.dgvAllRecords.RowTemplate.Height = 25;
            this.dgvAllRecords.ShowEditingIcon = false;
            this.dgvAllRecords.Size = new System.Drawing.Size(579, 272);
            this.dgvAllRecords.TabIndex = 2;
            // 
            // pnlTopAllRecords
            // 
            this.pnlTopAllRecords.Controls.Add(this.lblAllRecords);
            this.pnlTopAllRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopAllRecords.Location = new System.Drawing.Point(0, 0);
            this.pnlTopAllRecords.Name = "pnlTopAllRecords";
            this.pnlTopAllRecords.Size = new System.Drawing.Size(579, 50);
            this.pnlTopAllRecords.TabIndex = 0;
            // 
            // lblAllRecords
            // 
            this.lblAllRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAllRecords.Location = new System.Drawing.Point(3, 7);
            this.lblAllRecords.Name = "lblAllRecords";
            this.lblAllRecords.Size = new System.Drawing.Size(629, 37);
            this.lblAllRecords.TabIndex = 0;
            this.lblAllRecords.Text = "All Records";
            this.lblAllRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRightMain
            // 
            this.pnlRightMain.Controls.Add(this.dgvMostCommon);
            this.pnlRightMain.Controls.Add(this.pnlTopFemale);
            this.pnlRightMain.Controls.Add(this.dgvMale);
            this.pnlRightMain.Controls.Add(this.pnlTopMale);
            this.pnlRightMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightMain.Location = new System.Drawing.Point(581, 0);
            this.pnlRightMain.Name = "pnlRightMain";
            this.pnlRightMain.Size = new System.Drawing.Size(522, 643);
            this.pnlRightMain.TabIndex = 4;
            // 
            // dgvMostCommon
            // 
            this.dgvMostCommon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostCommon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMostCommon.Location = new System.Drawing.Point(0, 372);
            this.dgvMostCommon.MultiSelect = false;
            this.dgvMostCommon.Name = "dgvMostCommon";
            this.dgvMostCommon.RowHeadersVisible = false;
            this.dgvMostCommon.RowTemplate.Height = 25;
            this.dgvMostCommon.Size = new System.Drawing.Size(522, 271);
            this.dgvMostCommon.TabIndex = 5;
            // 
            // pnlTopFemale
            // 
            this.pnlTopFemale.Controls.Add(this.lblCommonRecords);
            this.pnlTopFemale.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopFemale.Location = new System.Drawing.Point(0, 322);
            this.pnlTopFemale.Name = "pnlTopFemale";
            this.pnlTopFemale.Size = new System.Drawing.Size(522, 50);
            this.pnlTopFemale.TabIndex = 5;
            // 
            // lblCommonRecords
            // 
            this.lblCommonRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCommonRecords.Location = new System.Drawing.Point(3, 7);
            this.lblCommonRecords.Name = "lblCommonRecords";
            this.lblCommonRecords.Size = new System.Drawing.Size(629, 37);
            this.lblCommonRecords.TabIndex = 1;
            this.lblCommonRecords.Text = "Common Records (Top 100)";
            this.lblCommonRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMale
            // 
            this.dgvMale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMale.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMale.Location = new System.Drawing.Point(0, 50);
            this.dgvMale.MultiSelect = false;
            this.dgvMale.Name = "dgvMale";
            this.dgvMale.RowHeadersVisible = false;
            this.dgvMale.RowTemplate.Height = 25;
            this.dgvMale.Size = new System.Drawing.Size(522, 272);
            this.dgvMale.TabIndex = 4;
            // 
            // pnlTopMale
            // 
            this.pnlTopMale.Controls.Add(this.lblAllMaleRecords);
            this.pnlTopMale.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMale.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMale.Name = "pnlTopMale";
            this.pnlTopMale.Size = new System.Drawing.Size(522, 50);
            this.pnlTopMale.TabIndex = 3;
            // 
            // lblAllMaleRecords
            // 
            this.lblAllMaleRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAllMaleRecords.Location = new System.Drawing.Point(3, 7);
            this.lblAllMaleRecords.Name = "lblAllMaleRecords";
            this.lblAllMaleRecords.Size = new System.Drawing.Size(629, 37);
            this.lblAllMaleRecords.TabIndex = 1;
            this.lblAllMaleRecords.Text = "All Male Records";
            this.lblAllMaleRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lbOperationResult);
            this.pnlHeader.Controls.Add(this.pnlListTop);
            this.pnlHeader.Controls.Add(this.lblOperationTime);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(384, 643);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblOperationTime
            // 
            this.lblOperationTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblOperationTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOperationTime.Location = new System.Drawing.Point(0, 616);
            this.lblOperationTime.Name = "lblOperationTime";
            this.lblOperationTime.Size = new System.Drawing.Size(384, 27);
            this.lblOperationTime.TabIndex = 2;
            this.lblOperationTime.Text = "Total Time:";
            this.lblOperationTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbOperationResult
            // 
            this.lbOperationResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOperationResult.FormattingEnabled = true;
            this.lbOperationResult.ItemHeight = 15;
            this.lbOperationResult.Location = new System.Drawing.Point(0, 44);
            this.lbOperationResult.Name = "lbOperationResult";
            this.lbOperationResult.Size = new System.Drawing.Size(384, 572);
            this.lbOperationResult.TabIndex = 1;
            // 
            // btnExecuteProcess
            // 
            this.btnExecuteProcess.Location = new System.Drawing.Point(190, 1);
            this.btnExecuteProcess.Name = "btnExecuteProcess";
            this.btnExecuteProcess.Size = new System.Drawing.Size(193, 43);
            this.btnExecuteProcess.TabIndex = 0;
            this.btnExecuteProcess.Text = "Execute Parallel Process";
            this.btnExecuteProcess.UseVisualStyleBackColor = true;
            this.btnExecuteProcess.Click += new System.EventHandler(this.btnExecuteProcess_Click);
            // 
            // cbExecutionType
            // 
            this.cbExecutionType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbExecutionType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbExecutionType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbExecutionType.FormattingEnabled = true;
            this.cbExecutionType.Items.AddRange(new object[] {
            "All Threads",
            "All Tasks",
            "Two Threads Two Tasks"});
            this.cbExecutionType.Location = new System.Drawing.Point(2, 11);
            this.cbExecutionType.Name = "cbExecutionType";
            this.cbExecutionType.Size = new System.Drawing.Size(182, 23);
            this.cbExecutionType.TabIndex = 3;
            // 
            // pnlListTop
            // 
            this.pnlListTop.Controls.Add(this.cbExecutionType);
            this.pnlListTop.Controls.Add(this.btnExecuteProcess);
            this.pnlListTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListTop.Location = new System.Drawing.Point(0, 0);
            this.pnlListTop.Name = "pnlListTop";
            this.pnlListTop.Size = new System.Drawing.Size(384, 44);
            this.pnlListTop.TabIndex = 3;
            // 
            // UsrCtrlParallelOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UsrCtrlParallelOperation";
            this.Size = new System.Drawing.Size(1487, 643);
            this.pnlMain.ResumeLayout(false);
            this.pnlLeftMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFemale)).EndInit();
            this.pnlTopMostCommon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRecords)).EndInit();
            this.pnlTopAllRecords.ResumeLayout(false);
            this.pnlRightMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostCommon)).EndInit();
            this.pnlTopFemale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMale)).EndInit();
            this.pnlTopMale.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlListTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMain;
        private Panel pnlHeader;
        private Panel pnlCenterMain;
        private Panel pnlLeftMain;
        private DataGridView dgvMostCommon;
        private Panel pnlTopMostCommon;
        private Label lblAllFemaleRecords;
        private DataGridView dgvAllRecords;
        private Panel pnlTopAllRecords;
        private Label lblAllRecords;
        private Panel pnlRightMain;
        private DataGridView dgvFemale;
        private Panel pnlTopFemale;
        private Label lblCommonRecords;
        private DataGridView dgvMale;
        private Panel pnlTopMale;
        private Label lblAllMaleRecords;
        private Button btnExecuteProcess;
        private ListBox lbOperationResult;
        private Label lblOperationTime;
        private ComboBox cbExecutionType;
        private Panel pnlListTop;
    }
}
