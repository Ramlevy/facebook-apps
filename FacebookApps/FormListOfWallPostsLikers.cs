using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApps
{
    public partial class FormListOfWallPostsLikers : Form
    {
        private User m_LoggedInUser;
        private LogicListOfWallPostsLikers m_LogicListOfWallPostsLikers;

        public User LoggedInUser
        {
            get { return m_LoggedInUser; }
            set
            {
                m_LoggedInUser = value;
            }
        }

        public FormListOfWallPostsLikers()
        {
            InitializeComponent();
            monthCalendar.MaxDate = DateTime.Today;
        }

        // %Singleton%
        private void buttonUpdateListBox_Click(object sender, EventArgs e)
        {
            m_LogicListOfWallPostsLikers = LogicListOfWallPostsLikers.GetInstance(m_LoggedInUser);
            labelLoading.Visible = true;
            labelLoading.Refresh();
            m_LogicListOfWallPostsLikers.LikesByFriends(listBoxNames, monthCalendar);
            labelLoading.Visible = false;
            labelLoading.Refresh();
        }

        private void listBoxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_LogicListOfWallPostsLikers.PostsOfSpecificLiker(listBoxPosts);
        }
    }
}
