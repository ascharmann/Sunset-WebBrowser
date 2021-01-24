namespace WebBrowser.UI
{
    partial class BookmarkManagerForm
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
            this.BookmarkManagerlistBox = new System.Windows.Forms.ListBox();
            this.BookmarktextBox = new System.Windows.Forms.TextBox();
            this.BookmarkSearchButton = new System.Windows.Forms.Button();
            this.deleteBookmarkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookmarkManagerlistBox
            // 
            this.BookmarkManagerlistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookmarkManagerlistBox.FormattingEnabled = true;
            this.BookmarkManagerlistBox.ItemHeight = 18;
            this.BookmarkManagerlistBox.Location = new System.Drawing.Point(0, 0);
            this.BookmarkManagerlistBox.Name = "BookmarkManagerlistBox";
            this.BookmarkManagerlistBox.Size = new System.Drawing.Size(800, 506);
            this.BookmarkManagerlistBox.TabIndex = 0;
            // 
            // BookmarktextBox
            // 
            this.BookmarktextBox.Location = new System.Drawing.Point(12, 453);
            this.BookmarktextBox.Name = "BookmarktextBox";
            this.BookmarktextBox.Size = new System.Drawing.Size(253, 26);
            this.BookmarktextBox.TabIndex = 1;
            // 
            // BookmarkSearchButton
            // 
            this.BookmarkSearchButton.Location = new System.Drawing.Point(271, 453);
            this.BookmarkSearchButton.Name = "BookmarkSearchButton";
            this.BookmarkSearchButton.Size = new System.Drawing.Size(75, 26);
            this.BookmarkSearchButton.TabIndex = 2;
            this.BookmarkSearchButton.Text = "Search";
            this.BookmarkSearchButton.UseVisualStyleBackColor = true;
            this.BookmarkSearchButton.Click += new System.EventHandler(this.BookmarkSearchButton_Click);
            // 
            // deleteBookmarkButton
            // 
            this.deleteBookmarkButton.Location = new System.Drawing.Point(352, 453);
            this.deleteBookmarkButton.Name = "deleteBookmarkButton";
            this.deleteBookmarkButton.Size = new System.Drawing.Size(138, 26);
            this.deleteBookmarkButton.TabIndex = 3;
            this.deleteBookmarkButton.Text = "Delete Bookmark";
            this.deleteBookmarkButton.UseVisualStyleBackColor = true;
            this.deleteBookmarkButton.Click += new System.EventHandler(this.deleteBookmarkButton_Click);
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.deleteBookmarkButton);
            this.Controls.Add(this.BookmarkSearchButton);
            this.Controls.Add(this.BookmarktextBox);
            this.Controls.Add(this.BookmarkManagerlistBox);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookmarkManagerForm";
            this.Text = "Bookmark Manager";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BookmarkManagerlistBox;
        private System.Windows.Forms.TextBox BookmarktextBox;
        private System.Windows.Forms.Button BookmarkSearchButton;
        private System.Windows.Forms.Button deleteBookmarkButton;
    }
}