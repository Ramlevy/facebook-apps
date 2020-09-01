namespace FacebookApps
{
    public partial class FormAlbumsSorting
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
            this.MaximizeBox = false;
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonPhotos = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonComments = new System.Windows.Forms.RadioButton();
            this.radioButtonLikes = new System.Windows.Forms.RadioButton();
            this.radioButtonDates = new System.Windows.Forms.RadioButton();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelComments = new System.Windows.Forms.Label();
            this.labelLikes = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox.SuspendLayout();
            this.groupBoxStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(134, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(600, 572);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // buttonPhotos
            // 
            this.buttonPhotos.BackColor = System.Drawing.Color.Transparent;
            this.buttonPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPhotos.Location = new System.Drawing.Point(329, 204);
            this.buttonPhotos.Name = "buttonPhotos";
            this.buttonPhotos.Size = new System.Drawing.Size(227, 163);
            this.buttonPhotos.TabIndex = 2;
            this.buttonPhotos.Text = "Get Photos !";
            this.buttonPhotos.UseVisualStyleBackColor = false;
            this.buttonPhotos.Click += new System.EventHandler(this.buttonPhotos_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.Enabled = false;
            this.buttonBack.Location = new System.Drawing.Point(9, 227);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(112, 49);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext.Enabled = false;
            this.buttonNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNext.Location = new System.Drawing.Point(756, 240);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(111, 51);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.radioButtonComments);
            this.groupBox.Controls.Add(this.radioButtonLikes);
            this.groupBox.Controls.Add(this.radioButtonDates);
            this.groupBox.Location = new System.Drawing.Point(9, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(119, 95);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Order By";
            // 
            // radioButtonComments
            // 
            this.radioButtonComments.AutoSize = true;
            this.radioButtonComments.Enabled = false;
            this.radioButtonComments.Location = new System.Drawing.Point(9, 66);
            this.radioButtonComments.Name = "radioButtonComments";
            this.radioButtonComments.Size = new System.Drawing.Size(74, 17);
            this.radioButtonComments.TabIndex = 2;
            this.radioButtonComments.TabStop = true;
            this.radioButtonComments.Text = "Comments";
            this.radioButtonComments.UseVisualStyleBackColor = true;
            this.radioButtonComments.CheckedChanged += new System.EventHandler(this.radioButtonComments_CheckedChanged);
            // 
            // radioButtonLikes
            // 
            this.radioButtonLikes.AutoSize = true;
            this.radioButtonLikes.Enabled = false;
            this.radioButtonLikes.Location = new System.Drawing.Point(9, 42);
            this.radioButtonLikes.Name = "radioButtonLikes";
            this.radioButtonLikes.Size = new System.Drawing.Size(50, 17);
            this.radioButtonLikes.TabIndex = 1;
            this.radioButtonLikes.Text = "Likes";
            this.radioButtonLikes.UseVisualStyleBackColor = true;
            // 
            // radioButtonDates
            // 
            this.radioButtonDates.AutoSize = true;
            this.radioButtonDates.Checked = true;
            this.radioButtonDates.Enabled = false;
            this.radioButtonDates.Location = new System.Drawing.Point(9, 19);
            this.radioButtonDates.Name = "radioButtonDates";
            this.radioButtonDates.Size = new System.Drawing.Size(48, 17);
            this.radioButtonDates.TabIndex = 0;
            this.radioButtonDates.TabStop = true;
            this.radioButtonDates.Text = "Date";
            this.radioButtonDates.UseVisualStyleBackColor = true;
            this.radioButtonDates.CheckedChanged += new System.EventHandler(this.radioButtonDates_CheckedChanged);
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.Controls.Add(this.label3);
            this.groupBoxStatistics.Controls.Add(this.label2);
            this.groupBoxStatistics.Controls.Add(this.label1);
            this.groupBoxStatistics.Controls.Add(this.labelComments);
            this.groupBoxStatistics.Controls.Add(this.labelLikes);
            this.groupBoxStatistics.Controls.Add(this.labelDate);
            this.groupBoxStatistics.Location = new System.Drawing.Point(740, 12);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(168, 150);
            this.groupBoxStatistics.TabIndex = 6;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Statistics";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Comments :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Likes :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date :";
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.BackColor = System.Drawing.Color.Azure;
            this.labelComments.Location = new System.Drawing.Point(55, 125);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(0, 13);
            this.labelComments.TabIndex = 3;
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.Location = new System.Drawing.Point(55, 85);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(0, 13);
            this.labelLikes.TabIndex = 2;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(55, 47);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 13);
            this.labelDate.TabIndex = 0;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLoading.Location = new System.Drawing.Point(23, 137);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(69, 16);
            this.labelLoading.TabIndex = 63;
            this.labelLoading.Text = "Loading ...";
            this.labelLoading.Visible = false;
            // 
            // FormAlbumsSorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(920, 596);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.groupBoxStatistics);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonPhotos);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAlbumsSorting";
            this.Text = "Albums sorting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxStatistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonPhotos;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioButtonLikes;
        private System.Windows.Forms.RadioButton radioButtonDates;
        private System.Windows.Forms.RadioButton radioButtonComments;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}