namespace Ui.Controls
{
    partial class UsrCtrlAsyncListAll
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
            this.lblAllRecords = new System.Windows.Forms.Label();
            this.pnlLeftMain = new System.Windows.Forms.Panel();
            this.dgvMostCommon = new System.Windows.Forms.DataGridView();
            this.pnlTopMostCommon = new System.Windows.Forms.Panel();
            this.lblAllFemaleRecords = new System.Windows.Forms.Label();
            this.dgvAllRecords = new System.Windows.Forms.DataGridView();
            this.pnlTopAllRecords = new System.Windows.Forms.Panel();
            this.pnlRightMain = new System.Windows.Forms.Panel();
            this.dgvFemale = new System.Windows.Forms.DataGridView();
            this.pnlTopFemale = new System.Windows.Forms.Panel();
            this.lblCommonRecords = new System.Windows.Forms.Label();
            this.dgvMale = new System.Windows.Forms.DataGridView();
            this.pnlTopMale = new System.Windows.Forms.Panel();
            this.lblAllMaleRecords = new System.Windows.Forms.Label();
            this.pnlCenterMain = new System.Windows.Forms.Panel();
            this.pnlLeftMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostCommon)).BeginInit();
            this.pnlTopMostCommon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRecords)).BeginInit();
            this.pnlTopAllRecords.SuspendLayout();
            this.pnlRightMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFemale)).BeginInit();
            this.pnlTopFemale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMale)).BeginInit();
            this.pnlTopMale.SuspendLayout();
            this.SuspendLayout();
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
            // pnlLeftMain
            // 
            this.pnlLeftMain.Controls.Add(this.dgvFemale);
            this.pnlLeftMain.Controls.Add(this.pnlTopMostCommon);
            this.pnlLeftMain.Controls.Add(this.dgvAllRecords);
            this.pnlLeftMain.Controls.Add(this.pnlTopAllRecords);
            this.pnlLeftMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftMain.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftMain.Name = "pnlLeftMain";
            this.pnlLeftMain.Size = new System.Drawing.Size(635, 647);
            this.pnlLeftMain.TabIndex = 3;
            // 
            // dgvMostCommon
            // 
            this.dgvMostCommon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostCommon.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMostCommon.Location = new System.Drawing.Point(0, 372);
            this.dgvMostCommon.MultiSelect = false;
            this.dgvMostCommon.Name = "dgvMostCommon";
            this.dgvMostCommon.RowHeadersVisible = false;
            this.dgvMostCommon.RowTemplate.Height = 25;
            this.dgvMostCommon.Size = new System.Drawing.Size(635, 272);
            this.dgvMostCommon.TabIndex = 5;
            // 
            // pnlTopMostCommon
            // 
            this.pnlTopMostCommon.Controls.Add(this.lblAllFemaleRecords);
            this.pnlTopMostCommon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMostCommon.Location = new System.Drawing.Point(0, 322);
            this.pnlTopMostCommon.Name = "pnlTopMostCommon";
            this.pnlTopMostCommon.Size = new System.Drawing.Size(635, 50);
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
            this.dgvAllRecords.Size = new System.Drawing.Size(635, 272);
            this.dgvAllRecords.TabIndex = 2;
            // 
            // pnlTopAllRecords
            // 
            this.pnlTopAllRecords.Controls.Add(this.lblAllRecords);
            this.pnlTopAllRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopAllRecords.Location = new System.Drawing.Point(0, 0);
            this.pnlTopAllRecords.Name = "pnlTopAllRecords";
            this.pnlTopAllRecords.Size = new System.Drawing.Size(635, 50);
            this.pnlTopAllRecords.TabIndex = 0;
            // 
            // pnlRightMain
            // 
            this.pnlRightMain.Controls.Add(this.dgvMostCommon);
            this.pnlRightMain.Controls.Add(this.pnlTopFemale);
            this.pnlRightMain.Controls.Add(this.dgvMale);
            this.pnlRightMain.Controls.Add(this.pnlTopMale);
            this.pnlRightMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightMain.Location = new System.Drawing.Point(643, 0);
            this.pnlRightMain.Name = "pnlRightMain";
            this.pnlRightMain.Size = new System.Drawing.Size(635, 647);
            this.pnlRightMain.TabIndex = 4;
            // 
            // dgvFemale
            // 
            this.dgvFemale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFemale.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFemale.Location = new System.Drawing.Point(0, 372);
            this.dgvFemale.MultiSelect = false;
            this.dgvFemale.Name = "dgvFemale";
            this.dgvFemale.RowHeadersVisible = false;
            this.dgvFemale.RowTemplate.Height = 25;
            this.dgvFemale.Size = new System.Drawing.Size(635, 272);
            this.dgvFemale.TabIndex = 6;
            // 
            // pnlTopFemale
            // 
            this.pnlTopFemale.Controls.Add(this.lblCommonRecords);
            this.pnlTopFemale.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopFemale.Location = new System.Drawing.Point(0, 322);
            this.pnlTopFemale.Name = "pnlTopFemale";
            this.pnlTopFemale.Size = new System.Drawing.Size(635, 50);
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
            this.dgvMale.Size = new System.Drawing.Size(635, 272);
            this.dgvMale.TabIndex = 4;
            // 
            // pnlTopMale
            // 
            this.pnlTopMale.Controls.Add(this.lblAllMaleRecords);
            this.pnlTopMale.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMale.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMale.Name = "pnlTopMale";
            this.pnlTopMale.Size = new System.Drawing.Size(635, 50);
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
            // pnlCenterMain
            // 
            this.pnlCenterMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenterMain.Location = new System.Drawing.Point(635, 0);
            this.pnlCenterMain.Name = "pnlCenterMain";
            this.pnlCenterMain.Size = new System.Drawing.Size(8, 647);
            this.pnlCenterMain.TabIndex = 5;
            // 
            // UsrCtrlAsyncListAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCenterMain);
            this.Controls.Add(this.pnlLeftMain);
            this.Controls.Add(this.pnlRightMain);
            this.Name = "UsrCtrlAsyncListAll";
            this.Size = new System.Drawing.Size(1278, 647);
            this.pnlLeftMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostCommon)).EndInit();
            this.pnlTopMostCommon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRecords)).EndInit();
            this.pnlTopAllRecords.ResumeLayout(false);
            this.pnlRightMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFemale)).EndInit();
            this.pnlTopFemale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMale)).EndInit();
            this.pnlTopMale.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblAllRecords;
        private Panel pnlLeftMain;
        private DataGridView dgvMostCommon;
        private Panel pnlTopMostCommon;
        private Label lblAllFemaleRecords;
        private DataGridView dgvAllRecords;
        private Panel pnlTopAllRecords;
        private Panel pnlRightMain;
        private DataGridView dgvFemale;
        private Panel pnlTopFemale;
        private Label lblCommonRecords;
        private DataGridView dgvMale;
        private Panel pnlTopMale;
        private Label lblAllMaleRecords;
        private Panel pnlCenterMain;
    }
}
