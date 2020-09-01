using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApps
{
    // %Factory Method%
    public class FormFactoryForFeatures
    {
        public static Form Create(Type i_TypeOfForm)
        {
            Form form = null;
            switch (i_TypeOfForm.Name)
            {
                case "FormListOfWallPostsLikers":
                    form = new FormListOfWallPostsLikers();
                    break;
                case "FormAlbumsSorting":
                    form = new FormAlbumsSorting();
                    break;
                default:
                    throw new Exception("Unavailable Form Type");
            }

            return form;
        }
    }
}
