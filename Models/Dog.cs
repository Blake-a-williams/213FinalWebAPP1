using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor213FinalWebAPP.Models;

    public class Dog
{
    public int Id { get; set; }

    public string? Images { get; set; }

    [Required]
    [StringLength(40, MinimumLength = 2)]
    public string? Name { get; set; }
    
    [Required]
    [StringLength(30, MinimumLength = 3)]
    public string? Breed { get; set; }
    
    [Required]
    [StringLength(15, MinimumLength = 4)]
    public string? Size { get; set; }
    
    [Required]
    [StringLength(20, MinimumLength = 2)]
    public string? Age { get; set; }
    
    [Required]
    public string? Description { get; set; }
    
    [StringLength(100, MinimumLength = 4)]
    public string? Other { get; set; }  
    [Required]
    [StringLength(8, MinimumLength = 4)]
    public string? Gender { get; set; }
    
    [Required]
    [StringLength(40, MinimumLength = 2)]
    public string? Temperament { get; set; }
}


