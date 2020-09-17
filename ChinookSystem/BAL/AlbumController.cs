using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Additonal Namespaces
using System.ComponentModel;
using ChinookSystem.ViewModels;
using ChinookSystem.DAL;

namespace ChinookSystem.BAL
{
    [DataObject]
    public class AlbumController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<AlbumViewModel> Album_List()
        {
            using (var context = new ChinookSystemContext())
            {
                //linq query
                //linq queries are returned as IEnumerable or IQueryable datasets
                //you can use var when declaring your query receiving variable
                var results = from x in context.Albums
                              select new AlbumViewModel
                              {
                                  AlbumId = x.AlbumId,
                                  Title = x.Title,
                                  ArtistId = x.ArtistId,
                                  ReleaseYear = x.ReleaseYear,
                                  ReleaseLabel = x.ReleaseLabel
                              };
                return results.OrderBy(x => x.AlbumId).ToList();
            }
        }
    }
}
