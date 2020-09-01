using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApps
{
    public class LogicListOfWallPostsLikers
    {
        private static LogicListOfWallPostsLikers s_Instance = null;
        private readonly Dictionary<string, string> r_LikerToPosts = new Dictionary<string, string>();
        private readonly List<string> r_NameOfLikers = new List<string>();
        private readonly User r_LoggedInUser;
        private ListBox m_ListBoxNames;
        private MonthCalendar m_MonthCalender;

        public static LogicListOfWallPostsLikers GetInstance(User i_LoggedInUser)
        {
            // $G$ DSN-999 (-5) This implementation isn't thread safe
            if (s_Instance == null)
            {
                s_Instance = new LogicListOfWallPostsLikers(i_LoggedInUser);
            }

            return s_Instance;
        }

        private LogicListOfWallPostsLikers(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
        }

        public void LikesByFriends(ListBox i_ListBoxNames, MonthCalendar i_MonthCalender)
        {
            m_ListBoxNames = i_ListBoxNames;
            m_MonthCalender = i_MonthCalender;
            FetchLikesFromFeed();
            countLikersFromList();
        }

        public void FetchLikesFromFeed()
        {
            int j = 0;
            r_LikerToPosts.Clear();    
            foreach (Post post in r_LoggedInUser.Posts)
            {
                if (m_MonthCalender.SelectionRange.Start < post.UpdateTime)
                {
                    if (post.LikedBy.Count() > 0)
                    {
                        for (int i = 0; i < post.LikedBy.Count; i++)
                        {
                            if (post.LikedBy[i].Name != r_LoggedInUser.Name)
                            {
                                r_NameOfLikers.Add(post.LikedBy[i].Name);
                                if (post.Message != null)
                                {
                                    r_LikerToPosts.Add(post.LikedBy[i].Name + " " + j++, post.Message);
                                }
                                else
                                {
                                    r_LikerToPosts.Add(post.LikedBy[i].Name + " " + j++, post.Type.ToString());
                                }
                            }
                        }
                    }
                }
                    else
                    {
                        break;
                    }
            }

                if (r_LoggedInUser.Posts.Count == 0)
                {
                    MessageBox.Show("You have no posts on your wall");
                }
            }

            private void countLikersFromList()
            {
                var likers = r_NameOfLikers.GroupBy(i => i).OrderByDescending(group => group.Count());
                string nameAndCount;
                m_ListBoxNames.Items.Clear();
                foreach (var grp in likers)
                {
                    nameAndCount = grp.Key + " " + grp.Count();
                    m_ListBoxNames.Items.Add(nameAndCount);
                }

                r_NameOfLikers.Clear();
            }

            public void PostsOfSpecificLiker(ListBox i_ListBoxPosts)
            {
                Dictionary<string, string> local = getLikersToPosts();
                string likerNameWithNumbers = m_ListBoxNames.SelectedItem.ToString();
                string likerName = Regex.Replace(likerNameWithNumbers, "[0-9]", string.Empty);
                i_ListBoxPosts.Items.Clear();
                foreach (var key in local.Keys)
                {
                    if (key.Contains(likerName))
                    {
                        i_ListBoxPosts.Items.Add(local[key]);
                    }
                }
            }

            public Dictionary<string, string> getLikersToPosts()
            {
                return r_LikerToPosts;
            }
     }
}