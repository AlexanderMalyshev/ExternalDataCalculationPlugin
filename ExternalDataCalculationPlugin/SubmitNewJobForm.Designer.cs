namespace ExternalDataCalculationPlugin
{
    partial class SubmitNewJobForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.JobNameTextBox = new System.Windows.Forms.TextBox();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.CancelJobWindowButton = new System.Windows.Forms.Button();
            this.SubmitJobWindowButton = new System.Windows.Forms.Button();
            this.JobNameLabel = new System.Windows.Forms.Label();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.QueryLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JobNameTextBox
            // 
            this.JobNameTextBox.Location = new System.Drawing.Point(165, 44);
            this.JobNameTextBox.Name = "JobNameTextBox";
            this.JobNameTextBox.Size = new System.Drawing.Size(800, 38);
            this.JobNameTextBox.TabIndex = 0;
            this.JobNameTextBox.Text = "MyJob";
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(165, 104);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(800, 38);
            this.FromTextBox.TabIndex = 1;
            this.FromTextBox.Text = "hsql::xlextdat10r2\\FoodMarket\\Transactions";
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(165, 633);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(800, 38);
            this.ToTextBox.TabIndex = 2;
            this.ToTextBox.Text = "aztbl::https://excelexternalcalcstorage.table.core.windows.net/agregatedTransacti" +
    "ons";
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Location = new System.Drawing.Point(165, 169);
            this.QueryTextBox.Multiline = true;
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(800, 438);
            this.QueryTextBox.TabIndex = 3;
            this.QueryTextBox.Text = "Select * from Transactions";
            // 
            // CancelJobWindowButton
            // 
            this.CancelJobWindowButton.Location = new System.Drawing.Point(789, 699);
            this.CancelJobWindowButton.Name = "CancelJobWindowButton";
            this.CancelJobWindowButton.Size = new System.Drawing.Size(176, 77);
            this.CancelJobWindowButton.TabIndex = 4;
            this.CancelJobWindowButton.Text = "Cancel";
            this.CancelJobWindowButton.UseVisualStyleBackColor = true;
            this.CancelJobWindowButton.Click += new System.EventHandler(this.CancelJobWindowButton_Click);
            // 
            // SubmitJobWindowButton
            // 
            this.SubmitJobWindowButton.Location = new System.Drawing.Point(593, 699);
            this.SubmitJobWindowButton.Name = "SubmitJobWindowButton";
            this.SubmitJobWindowButton.Size = new System.Drawing.Size(176, 77);
            this.SubmitJobWindowButton.TabIndex = 5;
            this.SubmitJobWindowButton.Text = "Submit";
            this.SubmitJobWindowButton.UseVisualStyleBackColor = true;
            this.SubmitJobWindowButton.Click += new System.EventHandler(this.SubmitJobWindowButton_Click);
            // 
            // JobNameLabel
            // 
            this.JobNameLabel.AutoSize = true;
            this.JobNameLabel.Location = new System.Drawing.Point(16, 50);
            this.JobNameLabel.Name = "JobNameLabel";
            this.JobNameLabel.Size = new System.Drawing.Size(143, 32);
            this.JobNameLabel.TabIndex = 6;
            this.JobNameLabel.Text = "Job Name";
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(16, 110);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(105, 32);
            this.SourceLabel.TabIndex = 7;
            this.SourceLabel.Text = "Source";
            // 
            // QueryLabel
            // 
            this.QueryLabel.AutoSize = true;
            this.QueryLabel.Location = new System.Drawing.Point(16, 169);
            this.QueryLabel.Name = "QueryLabel";
            this.QueryLabel.Size = new System.Drawing.Size(92, 32);
            this.QueryLabel.TabIndex = 8;
            this.QueryLabel.Text = "Query";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(16, 639);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(97, 32);
            this.ToLabel.TabIndex = 9;
            this.ToLabel.Text = "Target";
            // 
            // SubmitNewJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 788);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.QueryLabel);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.JobNameLabel);
            this.Controls.Add(this.SubmitJobWindowButton);
            this.Controls.Add(this.CancelJobWindowButton);
            this.Controls.Add(this.QueryTextBox);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.JobNameTextBox);
            this.Name = "SubmitNewJobForm";
            this.Text = "Create New Job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox JobNameTextBox;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.Button CancelJobWindowButton;
        private System.Windows.Forms.Button SubmitJobWindowButton;
        private System.Windows.Forms.Label JobNameLabel;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label QueryLabel;
        private System.Windows.Forms.Label ToLabel;
    }
}