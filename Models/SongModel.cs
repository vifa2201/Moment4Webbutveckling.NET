using System.ComponentModel.DataAnnotations;

namespace Moment4.Models;

public class SongModel{
    public int Id {get; set;}
    [Required]
     public string? Title {get; set;}
     [Required]
      public int Length {get; set;}
    [Required]
  // Referens modell
        public int ArtistId { get; set; }
        public ArtistModel? Artist { get; set; }

       //referens modell
       public int? CategoryId {get; set;}

    public CategoryModel? Category {get; set;}
}