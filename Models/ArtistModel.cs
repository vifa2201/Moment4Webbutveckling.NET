using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Moment4.Models
{
    public class ArtistModel
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        // relation
 
        public List<SongModel>? Songs { get; set; }
    }
}