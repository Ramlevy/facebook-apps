using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookApps
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 1000;
        }

        private User m_LoggedInUser;

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login("1733380210281555", "public_profile", "user_actions.news", "user_friends", "publish_actions", "user_events", "user_photos", "user_posts", "user_videos", "publish_actions", "rsvp_event");
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show("You must log in to use this application ! \n" + result.ErrorMessage);
                this.Dispose();
            }
        }

        private void fetchUserInfo()
        {
            textBoxStatus.Text = "What's on your mind ?";
            picture_smallPictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
            labelName.Text = m_LoggedInUser.Name;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            Status postedStatus = m_LoggedInUser.PostStatus(textBoxStatus.Text);
            MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
        }

        private void addPostToListBoxPosts(Post i_PostToAdd)
        {
            if (i_PostToAdd.Message != null)
            {
                listBoxPosts.Items.Add(i_PostToAdd.Message);
            }
            else if (i_PostToAdd.Caption != null)
            {
                listBoxPosts.Items.Add(i_PostToAdd.Caption);
            }
            else
            {
                listBoxPosts.Items.Add(string.Format("[{0}]", i_PostToAdd.Type));
            }
        }

        // %Async Programming%
        private void fetchPosts()
        {
            new Thread(() =>
            {
                var posts = m_LoggedInUser.NewsFeed;
                foreach (Post post in posts)
                {
                    if (!listBoxPosts.InvokeRequired)
                    {
                        addPostToListBoxPosts(post);
                    }
                    else
                    {
                        listBoxPosts.Invoke(new Action(() => addPostToListBoxPosts(post)));
                    }
                }
            }).Start();
        }

        private void linkFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFriends();
        }

        // %Data Binding% %Async Programming%
        private void fetchFriends()
        {
            var allFriends = m_LoggedInUser.Friends;

            if (!listBoxFriends.InvokeRequired)
            {
                userBindingSource.DataSource = allFriends;
            }
            else
            {
                listBoxFriends.Invoke(new Action(() =>
                    {
                        foreach (User friend in allFriends)
                        {
                            listBoxFriends.Items.Add(friend);
                        }
                    }));
            }
        }

        private void labelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchEvents();
        }

        // %Async Programming%
        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";

            listBoxEvents.Invoke(new Action(() =>
            {
                foreach (Event fbEvent in m_LoggedInUser.Events)
                {
                    listBoxEvents.Items.Add(fbEvent);
                }

                if (m_LoggedInUser.Events.Count == 0)
                {
                    MessageBox.Show("No Events to retrieve");
                }
            }));
        }

        private void linkPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchLikedPages();
        }

        // %Async Programming%
        private void fetchLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";

            listBoxLikedPages.Invoke(new Action(() =>
                {
                    foreach (Page page in m_LoggedInUser.LikedPages)
                    {
                        listBoxLikedPages.Items.Add(page);
                    }

                    if (m_LoggedInUser.LikedPages.Count == 0)
                    {
                        MessageBox.Show("No liked pages to retrieve");
                    }
                }));
        }

        // %Factory Method%
        private void buttonListOfLikers_Click(object sender, EventArgs e)
        {
            Form listOfWallPostsLikers = FormFactoryForFeatures.Create(typeof(FormListOfWallPostsLikers));
            (listOfWallPostsLikers as FormListOfWallPostsLikers).LoggedInUser = m_LoggedInUser;
            listOfWallPostsLikers.ShowDialog();
        }

        // %Factory Method%
        private void buttonAlbumsSorting_Click(object sender, EventArgs e)
        {
            Form albumsSorting = FormFactoryForFeatures.Create(typeof(FormAlbumsSorting));
            (albumsSorting as FormAlbumsSorting).LoggedInUser = m_LoggedInUser;
            albumsSorting.ShowDialog();
        }
    }
}
