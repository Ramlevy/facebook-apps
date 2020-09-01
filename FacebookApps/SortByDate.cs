using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApps
{
    // %Strategy%
    public class SortByDate : ISortStrategy
    {
        public List<Photo> OrderingStrategy(List<Photo> i_ListOfPhotos)
        {
            i_ListOfPhotos = i_ListOfPhotos.OrderByDescending(x => x.CreatedTime).ToList();
            return i_ListOfPhotos;
        }
    }
}
