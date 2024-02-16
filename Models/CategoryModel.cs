using System.ComponentModel.DataAnnotations;

namespace Moment4.Models;

public class CategoryModel{
    //properties
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }

    public List<SongModel>? SongModels {get; set; }
}