namespace Ui
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnPAOAction = new System.Windows.Forms.Button();
            this.btnPOAction = new System.Windows.Forms.Button();
            this.btnAOAction = new System.Windows.Forms.Button();
            this.btnSOAction = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblRecords = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnPAOAction);
            this.pnlHeader.Controls.Add(this.btnPOAction);
            this.pnlHeader.Controls.Add(this.btnAOAction);
            this.pnlHeader.Controls.Add(this.btnSOAction);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1559, 76);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnPAOAction
            // 
            this.btnPAOAction.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPAOAction.Location = new System.Drawing.Point(1030, 8);
            this.btnPAOAction.Name = "btnPAOAction";
            this.btnPAOAction.Size = new System.Drawing.Size(337, 60);
            this.btnPAOAction.TabIndex = 3;
            this.btnPAOAction.Text = "Parallel Async Operations";
            this.btnPAOAction.UseVisualStyleBackColor = true;
            this.btnPAOAction.Visible = false;
            this.btnPAOAction.Click += new System.EventHandler(this.btnPAOAction_Click);
            // 
            // btnPOAction
            // 
            this.btnPOAction.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPOAction.Location = new System.Drawing.Point(693, 8);
            this.btnPOAction.Name = "btnPOAction";
            this.btnPOAction.Size = new System.Drawing.Size(337, 60);
            this.btnPOAction.TabIndex = 2;
            this.btnPOAction.Text = "Parallel Operations";
            this.btnPOAction.UseVisualStyleBackColor = true;
            this.btnPOAction.Click += new System.EventHandler(this.btnPOAction_Click);
            // 
            // btnAOAction
            // 
            this.btnAOAction.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAOAction.Location = new System.Drawing.Point(356, 8);
            this.btnAOAction.Name = "btnAOAction";
            this.btnAOAction.Size = new System.Drawing.Size(337, 60);
            this.btnAOAction.TabIndex = 1;
            this.btnAOAction.Text = "Asynchronous Operations";
            this.btnAOAction.UseVisualStyleBackColor = true;
            this.btnAOAction.Click += new System.EventHandler(this.btnAOAction_Click);
            // 
            // btnSOAction
            // 
            this.btnSOAction.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSOAction.Location = new System.Drawing.Point(19, 8);
            this.btnSOAction.Name = "btnSOAction";
            this.btnSOAction.Size = new System.Drawing.Size(337, 60);
            this.btnSOAction.TabIndex = 0;
            this.btnSOAction.Text = "Synchronous Operations";
            this.btnSOAction.UseVisualStyleBackColor = true;
            this.btnSOAction.Click += new System.EventHandler(this.btnSOAction_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 76);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1559, 550);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblRecords);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 626);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1559, 60);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblRecords
            // 
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecords.Location = new System.Drawing.Point(4, 6);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(489, 45);
            this.lblRecords.TabIndex = 1;
            this.lblRecords.Text = "Records: ";
            this.lblRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 686);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlHeader;
        private Button btnAOAction;
        private Button btnSOAction;
        private Button btnPAOAction;
        private Button btnPOAction;
        private Panel pnlBody;
        private Panel pnlFooter;
        private Label lblRecords;
    }
}