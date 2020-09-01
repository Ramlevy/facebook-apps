namespace FacebookApps
{
    public partial class FormListOfWallPostsLikers
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
            System.Windows.Forms.Button buttonUpdateListBox;
            this.MaximizeBox = false;
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.labelLoading = new System.Windows.Forms.Label();
            buttonUpdateListBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUpdateListBox
            // 
            buttonUpdateListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            buttonUpdateListBox.Location = new System.Drawing.Point(302, 53);
            buttonUpdateListBox.Margin = new System.Windows.Forms.Padding(4);
            buttonUpdateListBox.Name = "buttonUpdateListBox";
            buttonUpdateListBox.Size = new System.Drawing.Size(309, 92);
            buttonUpdateListBox.TabIndex = 59;
            buttonUpdateListBox.Text = "Get list of wall posts likers";
            buttonUpdateListBox.UseVisualStyleBackColor = true;
            buttonUpdateListBox.Click += new System.EventHandler(this.buttonUpdateListBox_Click);
            // 
            // listBoxNames
            // 
            this.listBoxNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxNames.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listBoxNames.DisplayMember = "name";
            this.listBoxNames.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNames.ForeColor = System.Drawing.Color.White;
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.ItemHeight = 23;
            this.listBoxNames.Location = new System.Drawing.Point(11, 182);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(254, 165);
            this.listBoxNames.TabIndex = 52;
            this.listBoxNames.SelectedIndexChanged += new System.EventHandler(this.listBoxNames_SelectedIndexChanged);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(10, 13);
            this.monthCalendar.MaxDate = new System.DateTime(2016, 10, 10, 0, 0, 0, 0);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.MinDate = new System.DateTime(2006, 9, 26, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 53;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.ForeColor = System.Drawing.Color.White;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.HorizontalScrollbar = true;
            this.listBoxPosts.ItemHeight = 23;
            this.listBoxPosts.Location = new System.Drawing.Point(277, 181);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(376, 165);
            this.listBoxPosts.TabIndex = 60;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLoading.Location = new System.Drawing.Point(304, 19);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(69, 16);
            this.labelLoading.TabIndex = 62;
            this.labelLoading.Text = "Loading ...";
            this.labelLoading.Visible = false;
            // 
            // FormListOfWallPostsLikers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(665, 363);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(buttonUpdateListBox);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.listBoxNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormListOfWallPostsLikers";
            this.Text = "List of wall posts likers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelLoading;
    }
}