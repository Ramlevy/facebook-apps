using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApps
{
    public class LogicAlbumsSorting
    {
        private static LogicAlbumsSorting s_Instance = null;
        private readonly User r_LoggedInUser;
        private PictureBox m_PictureBox;
        private int m_PhotoIndex = 0;
        private List<Photo> m_ListOfPhotos = new List<Photo>();
        private GroupBox m_GroupBoxStatistics;
        private bool m_fetchPhotos = true;

        public ISortStrategy SortStrategy { get; set; }

        public static LogicAlbumsSorting GetInstance(User i_LoggedInUser)
        {
            if (s_Instance == null)
            {
                s_Instance = new LogicAlbumsSorting(i_LoggedInUser);
            }

            return s_Instance;
        }

        private LogicAlbumsSorting(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
        }

        public void PhotosData(PictureBox i_PictureBox, GroupBox i_GroupBoxStatistics)
        {
            m_PictureBox = i_PictureBox;
            m_GroupBoxStatistics = i_GroupBoxStatistics;
            SortStrategy = new SortByDate();
            UpdatePicture();
        }

        public int FetchPhotos()
        {
            if (m_fetchPhotos)
            {
                foreach (Album album in r_LoggedInUser.Albums)
                {
                    foreach (Photo photo in album.Photos)
                    {
                        m_ListOfPhotos.Add(photo);
                    }
                }

                m_fetchPhotos = false;
            }
           
            return m_ListOfPhotos.Count();
        }

        public void SwitchPhotos(bool i_IsNext, Button i_ButtonBack, Button i_ButtonNext)
        {
            if (i_IsNext)
            {
                m_PictureBox.LoadAsync(m_ListOfPhotos[++m_PhotoIndex].PictureNormalURL);
                updateStatistics();
            }
            else
            {
                m_PictureBox.LoadAsync(m_ListOfPhotos[--m_PhotoIndex].PictureNormalURL);
                updateStatistics();
            }

            if (m_PhotoIndex == 0)
            {
                i_ButtonBack.Enabled = false;
            }
            else if (m_PhotoIndex == m_ListOfPhotos.Count() - 1)
            {
                i_ButtonNext.Enabled = false;
            }
            else if (m_PhotoIndex == 1)
            {
                i_ButtonBack.Enabled = true;
            }
            else if (m_PhotoIndex == m_ListOfPhotos.Count() - 2)
            {
                i_ButtonNext.Enabled = true;
            }
        }

        private void updateStatistics()
        {
            m_GroupBoxStatistics.Controls[3].Text = m_ListOfPhotos[m_PhotoIndex].Comments.Count().ToString();
            m_GroupBoxStatistics.Controls[4].Text = m_ListOfPhotos[m_PhotoIndex].LikedBy.Count().ToString();
            m_GroupBoxStatistics.Controls[5].Text = m_ListOfPhotos[m_PhotoIndex].CreatedTime.ToString();
        }

        // %Strategy%
        public void Sort()
        {
            m_ListOfPhotos = SortStrategy.OrderingStrategy(m_ListOfPhotos);
        }

        public void UpdatePicture()
        {
            m_PictureBox.LoadAsync(m_ListOfPhotos[0].PictureNormalURL);
            m_PhotoIndex = 0;
            updateStatistics();
        }
    }
}
