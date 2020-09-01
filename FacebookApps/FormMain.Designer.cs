namespace FacebookApps
{
    public partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label localeLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label updateTimeLabel;
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.linkFriends = new System.Windows.Forms.LinkLabel();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelEvents = new System.Windows.Forms.LinkLabel();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.linkPages = new System.Windows.Forms.LinkLabel();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.buttonListOfLikers = new System.Windows.Forms.Button();
            this.picture_smallPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonAlbumsSorting = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.localeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.updateTimeTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            birthdayLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            localeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            updateTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(12, 67);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 110;
            birthdayLabel.Text = "Birthday:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 114;
            idLabel.Text = "Id:";
            // 
            // localeLabel
            // 
            localeLabel.AutoSize = true;
            localeLabel.Location = new System.Drawing.Point(410, 15);
            localeLabel.Name = "localeLabel";
            localeLabel.Size = new System.Drawing.Size(42, 13);
            localeLabel.TabIndex = 118;
            localeLabel.Text = "Locale:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 120;
            nameLabel.Text = "Name:";
            // 
            // updateTimeLabel
            // 
            updateTimeLabel.AutoSize = true;
            updateTimeLabel.Location = new System.Drawing.Point(410, 44);
            updateTimeLabel.Name = "updateTimeLabel";
            updateTimeLabel.Size = new System.Drawing.Size(71, 13);
            updateTimeLabel.TabIndex = 122;
            updateTimeLabel.Text = "Update Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(110, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Post Status :";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Location = new System.Drawing.Point(114, 40);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(196, 69);
            this.textBoxStatus.TabIndex = 46;
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetStatus.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSetStatus.Location = new System.Drawing.Point(216, 5);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(94, 28);
            this.buttonSetStatus.TabIndex = 47;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // linkPosts
            // 
            this.linkPosts.AutoSize = true;
            this.linkPosts.Location = new System.Drawing.Point(11, 122);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(108, 13);
            this.linkPosts.TabIndex = 50;
            this.linkPosts.TabStop = true;
            this.linkPosts.Text = "Fetch My News Feed";
            this.linkPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPosts_LinkClicked);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.AllowDrop = true;
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.ForeColor = System.Drawing.Color.White;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 23;
            this.listBoxPosts.Location = new System.Drawing.Point(14, 138);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(296, 96);
            this.listBoxPosts.TabIndex = 51;
            // 
            // linkFriends
            // 
            this.linkFriends.AutoSize = true;
            this.linkFriends.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkFriends.Location = new System.Drawing.Point(335, 250);
            this.linkFriends.Name = "linkFriends";
            this.linkFriends.Size = new System.Drawing.Size(71, 13);
            this.linkFriends.TabIndex = 52;
            this.linkFriends.TabStop = true;
            this.linkFriends.Text = "Fetch Friends";
            this.linkFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFriends_LinkClicked);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFriends.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listBoxFriends.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxFriends.DataSource = this.userBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriends.ForeColor = System.Drawing.Color.White;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.HorizontalScrollbar = true;
            this.listBoxFriends.ItemHeight = 23;
            this.listBoxFriends.Location = new System.Drawing.Point(338, 264);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(314, 96);
            this.listBoxFriends.TabIndex = 53;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.labelEvents.Location = new System.Drawing.Point(9, 246);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(73, 17);
            this.labelEvents.TabIndex = 54;
            this.labelEvents.TabStop = true;
            this.labelEvents.Text = "Fetch Events \r";
            this.labelEvents.UseCompatibleTextRendering = true;
            this.labelEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelEvents_LinkClicked);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listBoxEvents.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.ForeColor = System.Drawing.Color.White;
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 23;
            this.listBoxEvents.Location = new System.Drawing.Point(9, 264);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(301, 96);
            this.listBoxEvents.TabIndex = 55;
            // 
            // linkPages
            // 
            this.linkPages.AutoSize = true;
            this.linkPages.LinkArea = new System.Windows.Forms.LinkArea(0, 17);
            this.linkPages.Location = new System.Drawing.Point(332, 122);
            this.linkPages.Name = "linkPages";
            this.linkPages.Size = new System.Drawing.Size(96, 13);
            this.linkPages.TabIndex = 56;
            this.linkPages.TabStop = true;
            this.linkPages.Text = "Fetch Liked Pages";
            this.linkPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPages_LinkClicked);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLikedPages.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listBoxLikedPages.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxLikedPages.DisplayMember = "name";
            this.listBoxLikedPages.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLikedPages.ForeColor = System.Drawing.Color.White;
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.HorizontalScrollbar = true;
            this.listBoxLikedPages.ItemHeight = 23;
            this.listBoxLikedPages.Location = new System.Drawing.Point(335, 138);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(317, 96);
            this.listBoxLikedPages.TabIndex = 57;
            // 
            // buttonListOfLikers
            // 
            this.buttonListOfLikers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.buttonListOfLikers.Location = new System.Drawing.Point(335, 28);
            this.buttonListOfLikers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonListOfLikers.Name = "buttonListOfLikers";
            this.buttonListOfLikers.Size = new System.Drawing.Size(156, 81);
            this.buttonListOfLikers.TabIndex = 58;
            this.buttonListOfLikers.Text = "Get an ascending list of people who liked your wall posts";
            this.buttonListOfLikers.UseVisualStyleBackColor = true;
            this.buttonListOfLikers.Click += new System.EventHandler(this.buttonListOfLikers_Click);
            // 
            // picture_smallPictureBox
            // 
            this.picture_smallPictureBox.Location = new System.Drawing.Point(9, 40);
            this.picture_smallPictureBox.Name = "picture_smallPictureBox";
            this.picture_smallPictureBox.Size = new System.Drawing.Size(99, 69);
            this.picture_smallPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_smallPictureBox.TabIndex = 48;
            this.picture_smallPictureBox.TabStop = false;
            // 
            // buttonAlbumsSorting
            // 
            this.buttonAlbumsSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.buttonAlbumsSorting.Location = new System.Drawing.Point(499, 28);
            this.buttonAlbumsSorting.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAlbumsSorting.Name = "buttonAlbumsSorting";
            this.buttonAlbumsSorting.Size = new System.Drawing.Size(150, 81);
            this.buttonAlbumsSorting.TabIndex = 59;
            this.buttonAlbumsSorting.Text = "View your album pictures and their statistics";
            this.buttonAlbumsSorting.UseVisualStyleBackColor = true;
            this.buttonAlbumsSorting.Click += new System.EventHandler(this.buttonAlbumsSorting_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.Location = new System.Drawing.Point(19, 14);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 16);
            this.labelName.TabIndex = 110;
            this.labelName.Text = "Name";
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(93, 64);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(100, 20);
            this.birthdayTextBox.TabIndex = 111;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(93, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 115;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(250, 9);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(111, 81);
            this.imageNormalPictureBox.TabIndex = 117;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // localeTextBox
            // 
            this.localeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Locale", true));
            this.localeTextBox.Location = new System.Drawing.Point(491, 12);
            this.localeTextBox.Name = "localeTextBox";
            this.localeTextBox.Size = new System.Drawing.Size(100, 20);
            this.localeTextBox.TabIndex = 119;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(93, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 121;
            // 
            // updateTimeTextBox
            // 
            this.updateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UpdateTime", true));
            this.updateTimeTextBox.Location = new System.Drawing.Point(491, 41);
            this.updateTimeTextBox.Name = "updateTimeTextBox";
            this.updateTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateTimeTextBox.TabIndex = 123;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.imageNormalPictureBox);
            this.panel2.Controls.Add(birthdayLabel);
            this.panel2.Controls.Add(localeLabel);
            this.panel2.Controls.Add(this.localeTextBox);
            this.panel2.Controls.Add(this.updateTimeTextBox);
            this.panel2.Controls.Add(nameLabel);
            this.panel2.Controls.Add(this.idTextBox);
            this.panel2.Controls.Add(this.birthdayTextBox);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(idLabel);
            this.panel2.Controls.Add(updateTimeLabel);
            this.panel2.Location = new System.Drawing.Point(22, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 96);
            this.panel2.TabIndex = 124;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(678, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonAlbumsSorting);
            this.Controls.Add(this.buttonListOfLikers);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.linkPages);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.linkFriends);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.linkPosts);
            this.Controls.Add(this.picture_smallPictureBox);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Basic Facebook Experience";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.PictureBox picture_smallPictureBox;
        private System.Windows.Forms.LinkLabel linkPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.LinkLabel linkFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.LinkLabel labelEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.LinkLabel linkPages;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Button buttonListOfLikers;
        private System.Windows.Forms.Button buttonAlbumsSorting;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.TextBox localeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox updateTimeTextBox;
        private System.Windows.Forms.Panel panel2;
    }
}
