using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApps
{
    // %Strategy%
    public interface ISortStrategy
    {
        List<Photo> OrderingStrategy(List<Photo> i_ListOfPhotos);
    }
}
