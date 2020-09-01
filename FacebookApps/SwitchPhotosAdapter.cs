using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApps
{
    public interface ISwitchPhotos
    {
        void SwitchPhotos(bool i_IsNext, Button i_Button);
    }

    public class SwitchPhotosAdapter : ISwitchPhotos
    {
        public LogicAlbumsSorting Adoptee { get; set; }

        public Button ButtonBack { get; set; }

        public Button ButtonNext { get; set; }

        public void SwitchPhotos(bool i_IsNext, Button i_Button)
        {
            if (i_Button == ButtonBack)
            {
                Adoptee.SwitchPhotos(i_IsNext, i_Button, ButtonNext);
            }
            else if (i_Button == ButtonNext)
            {
                Adoptee.SwitchPhotos(i_IsNext, ButtonBack, i_Button);
            }
        }
    }
}
