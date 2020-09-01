using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApps
{
    public partial class FormAlbumsSorting : Form
    {
        private const bool v_IsNext = true;
        private User m_LoggedInUser;
        private LogicAlbumsSorting m_LogicAlbumsSorting;
        private ISwitchPhotos m_SwitchPhotosAdapter;

        public User LoggedInUser
        {
            get { return m_LoggedInUser; }
            set
            {
                m_LoggedInUser = value;
            }
        }

        public FormAlbumsSorting()
        {
            InitializeComponent();
        }

        // %Adapter%
        private void buttonBack_Click(object sender, EventArgs e)
        {
            m_SwitchPhotosAdapter.SwitchPhotos(!v_IsNext, buttonBack);
        }

        // %Adapter%
        private void buttonNext_Click(object sender, EventArgs e)
        {
            m_SwitchPhotosAdapter.SwitchPhotos(v_IsNext, buttonNext);
        }

        // %Singleton% %Adapter%
        private void buttonPhotos_Click(object sender, EventArgs e)
        {
            int photosCount = 0;
            
            m_LogicAlbumsSorting = LogicAlbumsSorting.GetInstance(m_LoggedInUser);
            buttonPhotos.Visible = false;
            enableLoading();
            m_SwitchPhotosAdapter = new SwitchPhotosAdapter() { Adoptee = m_LogicAlbumsSorting, ButtonBack = buttonBack, ButtonNext = buttonNext };
            photosCount = m_LogicAlbumsSorting.FetchPhotos();
            if (photosCount == 0)
            {
                MessageBox.Show("You have no photos in your albums");
                this.Close();
            }
            else
            {
                m_LogicAlbumsSorting.PhotosData(pictureBox, groupBoxStatistics);
            }

            disableLoading();
            enableRadioButtons();
            buttonNext.Enabled = true;
        }

        private void enableRadioButtons()
        {
            var radioButtons = groupBox.Controls.OfType<RadioButton>();
            foreach (RadioButton button in radioButtons)
            {
                button.Enabled = true;
            }
        }

        private void radioButtonDates_CheckedChanged(object sender, EventArgs e)
        {
            activateSort();
        }

        private void radioButtonLikes_CheckedChanged(object sender, EventArgs e)
        {
            activateSort();
        }

        private void radioButtonComments_CheckedChanged(object sender, EventArgs e)
        {
            activateSort();
        }

        // %Strategy%
        private void activateSort()
        {
            enableLoading();
            buttonBack.Enabled = false;
            if (radioButtonDates.Checked)
            {
                m_LogicAlbumsSorting.SortStrategy = new SortByDate();
            }
            else if (radioButtonLikes.Checked)
            {
                m_LogicAlbumsSorting.SortStrategy = new SortByLikes();
            }
            else if (radioButtonComments.Checked)
            {
                m_LogicAlbumsSorting.SortStrategy = new SortByComments();
            }

            m_LogicAlbumsSorting.Sort();
            m_LogicAlbumsSorting.UpdatePicture();
            disableLoading();
        }

        private void disableLoading()
        {
            labelLoading.Visible = false;
            labelLoading.Refresh();
        }

        private void enableLoading()
        {
            labelLoading.Visible = true;
            labelLoading.Refresh();
        }
    }
}
