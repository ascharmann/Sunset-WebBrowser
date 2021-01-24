namespace WebBrowser.UI
{
    partial class HistoryManagerForm
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
            this.HistoryListBox = new System.Windows.Forms.ListBox();
            this.historySearchTextBox = new System.Windows.Forms.TextBox();
            this.historySearchButton = new System.Windows.Forms.Button();
            this.clearHistoryButton = new System.Windows.Forms.Button();
            this.deleteHistoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HistoryListBox
            // 
            this.HistoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryListBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryListBox.FormattingEnabled = true;
            this.HistoryListBox.ItemHeight = 18;
            this.HistoryListBox.Location = new System.Drawing.Point(0, 0);
            this.HistoryListBox.Name = "HistoryListBox";
            this.HistoryListBox.Size = new System.Drawing.Size(800, 506);
            this.HistoryListBox.TabIndex = 0;
            // 
            // historySearchTextBox
            // 
            this.historySearchTextBox.Location = new System.Drawing.Point(12, 452);
            this.historySearchTextBox.Name = "historySearchTextBox";
            this.historySearchTextBox.Size = new System.Drawing.Size(248, 26);
            this.historySearchTextBox.TabIndex = 1;
            // 
            // historySearchButton
            // 
            this.historySearchButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historySearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.historySearchButton.Location = new System.Drawing.Point(266, 450);
            this.historySearchButton.Name = "historySearchButton";
            this.historySearchButton.Size = new System.Drawing.Size(81, 28);
            this.historySearchButton.TabIndex = 2;
            this.historySearchButton.Text = "Search";
            this.historySearchButton.UseVisualStyleBackColor = true;
            this.historySearchButton.Click += new System.EventHandler(this.historySearchButton_Click);
            // 
            // clearHistoryButton
            // 
            this.clearHistoryButton.Location = new System.Drawing.Point(640, 452);
            this.clearHistoryButton.Name = "clearHistoryButton";
            this.clearHistoryButton.Size = new System.Drawing.Size(148, 28);
            this.clearHistoryButton.TabIndex = 3;
            this.clearHistoryButton.Text = "Clear History";
            this.clearHistoryButton.UseVisualStyleBackColor = true;
            this.clearHistoryButton.Click += new System.EventHandler(this.clearHistoryButton_Click);
            // 
            // deleteHistoryButton
            // 
            this.deleteHistoryButton.Location = new System.Drawing.Point(493, 452);
            this.deleteHistoryButton.Name = "deleteHistoryButton";
            this.deleteHistoryButton.Size = new System.Drawing.Size(141, 28);
            this.deleteHistoryButton.TabIndex = 4;
            this.deleteHistoryButton.Text = "Delete Selected";
            this.deleteHistoryButton.UseVisualStyleBackColor = true;
            this.deleteHistoryButton.Click += new System.EventHandler(this.deleteHistoryButton_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.deleteHistoryButton);
            this.Controls.Add(this.clearHistoryButton);
            this.Controls.Add(this.historySearchButton);
            this.Controls.Add(this.historySearchTextBox);
            this.Controls.Add(this.HistoryListBox);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HistoryManagerForm";
            this.Text = "History Manager";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HistoryListBox;
        private System.Windows.Forms.TextBox historySearchTextBox;
        private System.Windows.Forms.Button historySearchButton;
        private System.Windows.Forms.Button clearHistoryButton;
        private System.Windows.Forms.Button deleteHistoryButton;
    }
}