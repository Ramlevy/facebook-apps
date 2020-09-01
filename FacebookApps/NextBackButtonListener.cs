using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApps
{
    public class NextBackButtonListener : Button
    {
        // %Observer%
        private List<PictureBoxSubject> m_ListOfPictureBoxSubjects = new List<PictureBoxSubject>();
        private bool v_isNext;
        public void AddSubject(PictureBoxSubject i_PictureBoxToObserve)
        {
            m_ListOfPictureBoxSubjects.Add(i_PictureBoxToObserve);
            delegatePictureBox();
        }

        public NextBackButtonListener(bool i_IsNextButton)
        {
            v_isNext = i_IsNextButton;
        }

        private void notifyButtons(int i_PictureBoxIndex, int i_PictureCount)
        {

            if (i_PictureBoxIndex == 0)
            {
                if (v_isNext)
                    this.Enabled = true;
                else
                    this.Enabled = false;
            }
            else if (i_PictureBoxIndex == i_PictureCount - 1 && v_isNext)
            {
               this.Enabled = false;
            }
            else if (i_PictureBoxIndex == 1 && !v_isNext)
            {
                this.Enabled = true;
            }
            else if (i_PictureBoxIndex == i_PictureCount - 2 && v_isNext)
            {
                this.Enabled = true;
            }
        }

        private void delegatePictureBox()
        {
            foreach (PictureBoxSubject pictureBox in m_ListOfPictureBoxSubjects)
            {
                pictureBox.EnabledDelegate += this.notifyButtons;
            }
        }
    }
}
