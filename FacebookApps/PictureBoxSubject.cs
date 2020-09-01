using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApps
{
    // %Observer%
    public class PictureBoxSubject : PictureBox
    {
        public event Action<int, int> EnabledDelegate;
        public int PictureBoxIndex { get; set; }
        public int PictureCount { get; set; }

        private void notifyBehaviorEnabled(int i_PictureBoxIndex, int i_PictureCount)
        {
            if (EnabledDelegate != null)
            {
                EnabledDelegate.Invoke(i_PictureBoxIndex, i_PictureCount);
            }
        }

        public PictureBoxSubject()
        {
            PictureBoxIndex = 0;
            PictureCount = 0;
        }

        public void PicturesCountChanged()
        {
            notifyBehaviorEnabled(this.PictureBoxIndex, this.PictureCount);
        }
    }
}
