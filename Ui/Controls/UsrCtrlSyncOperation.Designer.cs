namespace Ui.Controls
{
    partial class UsrCtrlSyncOperation
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMostCommonRecords = new System.Windows.Forms.Button();
            this.btnAllFemaleRecords = new System.Windows.Forms.Button();
            this.btnAllMaleRecords = new System.Windows.Forms.Button();
            this.btnAllRecords = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnMostCommonRecords);
            this.pnlHeader.Controls.Add(this.btnAllRecords);
            this.pnlHeader.Controls.Add(this.btnAllFemaleRecords);
            this.pnlHeader.Controls.Add(this.btnAllMaleRecords);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(197, 600);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnMostCommonRecords
            // 
            this.btnMostCommonRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostCommonRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMostCommonRecords.Location = new System.Drawing.Point(18, 295);
            this.btnMostCommonRecords.Name = "btnMostCommonRecords";
            this.btnMostCommonRecords.Size = new System.Drawing.Size(161, 65);
            this.btnMostCommonRecords.TabIndex = 7;
            this.btnMostCommonRecords.Text = "Most Common Records (Top 100)";
            this.btnMostCommonRecords.UseVisualStyleBackColor = true;
            this.btnMostCommonRecords.Click += new System.EventHandler(this.btnMostCommonRecords_Click);
            // 
            // btnAllFemaleRecords
            // 
            this.btnAllFemaleRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllFemaleRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllFemaleRecords.Location = new System.Drawing.Point(18, 197);
            this.btnAllFemaleRecords.Name = "btnAllFemaleRecords";
            this.btnAllFemaleRecords.Size = new System.Drawing.Size(161, 55);
            this.btnAllFemaleRecords.TabIndex = 6;
            this.btnAllFemaleRecords.Text = "All Female Records";
            this.btnAllFemaleRecords.UseVisualStyleBackColor = true;
            this.btnAllFemaleRecords.Click += new System.EventHandler(this.btnAllFemaleRecords_Click);
            // 
            // btnAllMaleRecords
            // 
            this.btnAllMaleRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllMaleRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllMaleRecords.Location = new System.Drawing.Point(18, 119);
            this.btnAllMaleRecords.Name = "btnAllMaleRecords";
            this.btnAllMaleRecords.Size = new System.Drawing.Size(161, 35);
            this.btnAllMaleRecords.TabIndex = 5;
            this.btnAllMaleRecords.Text = "All Male Records";
            this.btnAllMaleRecords.UseVisualStyleBackColor = true;
            this.btnAllMaleRecords.Click += new System.EventHandler(this.btnAllMaleRecords_Click);
            // 
            // btnAllRecords
            // 
            this.btnAllRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllRecords.Location = new System.Drawing.Point(18, 41);
            this.btnAllRecords.Name = "btnAllRecords";
            this.btnAllRecords.Size = new System.Drawing.Size(161, 35);
            this.btnAllRecords.TabIndex = 4;
            this.btnAllRecords.Text = "All Records";
            this.btnAllRecords.UseVisualStyleBackColor = true;
            this.btnAllRecords.Click += new System.EventHandler(this.btnAllRecords_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(197, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1403, 600);
            this.pnlMain.TabIndex = 1;
            // 
            // UsrCtrlSyncOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UsrCtrlSyncOperation";
            this.Size = new System.Drawing.Size(1600, 600);
            this.Load += new System.EventHandler(this.UsrCtrlSyncOperation_Load);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlHeader;
        private Button btnAllRecords;
        private Button btnAllMaleRecords;
        private Button btnAllFemaleRecords;
        private Button btnMostCommonRecords;
        private Panel pnlMain;
    }
}
