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
            this.pnlHeader.Size = new System.Drawing.Size(954, 82);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnPAOAction
            // 
            this.btnPAOAction.Location = new System.Drawing.Point(378, 13);
            this.btnPAOAction.Name = "btnPAOAction";
            this.btnPAOAction.Size = new System.Drawing.Size(98, 57);
            this.btnPAOAction.TabIndex = 3;
            this.btnPAOAction.Text = "Parallel Async Operations";
            this.btnPAOAction.UseVisualStyleBackColor = true;
            this.btnPAOAction.Click += new System.EventHandler(this.btnPAOAction_Click);
            // 
            // btnPOAction
            // 
            this.btnPOAction.Location = new System.Drawing.Point(256, 13);
            this.btnPOAction.Name = "btnPOAction";
            this.btnPOAction.Size = new System.Drawing.Size(98, 57);
            this.btnPOAction.TabIndex = 2;
            this.btnPOAction.Text = "Parallel Operations";
            this.btnPOAction.UseVisualStyleBackColor = true;
            this.btnPOAction.Click += new System.EventHandler(this.btnPOAction_Click);
            // 
            // btnAOAction
            // 
            this.btnAOAction.Location = new System.Drawing.Point(134, 13);
            this.btnAOAction.Name = "btnAOAction";
            this.btnAOAction.Size = new System.Drawing.Size(98, 57);
            this.btnAOAction.TabIndex = 1;
            this.btnAOAction.Text = "Asynchronous Operations";
            this.btnAOAction.UseVisualStyleBackColor = true;
            this.btnAOAction.Click += new System.EventHandler(this.btnAOAction_Click);
            // 
            // btnSOAction
            // 
            this.btnSOAction.Location = new System.Drawing.Point(12, 13);
            this.btnSOAction.Name = "btnSOAction";
            this.btnSOAction.Size = new System.Drawing.Size(98, 57);
            this.btnSOAction.TabIndex = 0;
            this.btnSOAction.Text = "Synchronous Operations";
            this.btnSOAction.UseVisualStyleBackColor = true;
            this.btnSOAction.Click += new System.EventHandler(this.btnSOAction_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 82);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(954, 404);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblRecords);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 486);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(954, 34);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblRecords
            // 
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecords.Location = new System.Drawing.Point(3, 6);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(370, 23);
            this.lblRecords.TabIndex = 0;
            this.lblRecords.Text = "Records: ";
            this.lblRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 520);
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