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
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1782, 101);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnPAOAction
            // 
            this.btnPAOAction.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPAOAction.Location = new System.Drawing.Point(1177, 10);
            this.btnPAOAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPAOAction.Name = "btnPAOAction";
            this.btnPAOAction.Size = new System.Drawing.Size(385, 80);
            this.btnPAOAction.TabIndex = 3;
            this.btnPAOAction.Text = "Parallel Async Operations";
            this.btnPAOAction.UseVisualStyleBackColor = true;
            this.btnPAOAction.Visible = false;
            this.btnPAOAction.Click += new System.EventHandler(this.btnPAOAction_Click);
            // 
            // btnPOAction
            // 
            this.btnPOAction.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPOAction.Location = new System.Drawing.Point(792, 10);
            this.btnPOAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPOAction.Name = "btnPOAction";
            this.btnPOAction.Size = new System.Drawing.Size(385, 80);
            this.btnPOAction.TabIndex = 2;
            this.btnPOAction.Text = "Parallel Operations";
            this.btnPOAction.UseVisualStyleBackColor = true;
            this.btnPOAction.Click += new System.EventHandler(this.btnPOAction_Click);
            // 
            // btnAOAction
            // 
            this.btnAOAction.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAOAction.Location = new System.Drawing.Point(407, 10);
            this.btnAOAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAOAction.Name = "btnAOAction";
            this.btnAOAction.Size = new System.Drawing.Size(385, 80);
            this.btnAOAction.TabIndex = 1;
            this.btnAOAction.Text = "Asynchronous Operations";
            this.btnAOAction.UseVisualStyleBackColor = true;
            this.btnAOAction.Click += new System.EventHandler(this.btnAOAction_Click);
            // 
            // btnSOAction
            // 
            this.btnSOAction.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSOAction.Location = new System.Drawing.Point(22, 10);
            this.btnSOAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSOAction.Name = "btnSOAction";
            this.btnSOAction.Size = new System.Drawing.Size(385, 80);
            this.btnSOAction.TabIndex = 0;
            this.btnSOAction.Text = "Synchronous Operations";
            this.btnSOAction.UseVisualStyleBackColor = true;
            this.btnSOAction.Click += new System.EventHandler(this.btnSOAction_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 101);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1782, 769);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblRecords);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 870);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1782, 45);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblRecords
            // 
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecords.Location = new System.Drawing.Point(3, 8);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(423, 31);
            this.lblRecords.TabIndex = 0;
            this.lblRecords.Text = "Records: ";
            this.lblRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 915);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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