using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ChinookSystem.Entities
{
    [Table("Albums")]
    internal class Album
    {
        [Key]
        public int AlbumId { get; set; }

        //validation anotation
        [Required(ErrorMessage = "Artist Name is required")]
        [StringLength(120, ErrorMessage = "Artist name is limited to 120 characters")]
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public int ReleaseYear { get; set; }
        public string ReleaseLabel { get; set; }
    }
}
