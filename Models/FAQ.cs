using System.ComponentModel.DataAnnotations;

namespace Blazor213FinalWebAPP.Models
{
    public class FAQ
{
        public int Id { get; set; }
        [Required]
        [StringLength(400, MinimumLength = 3)]
        public string? Question { get; set; }

        [Required]
        [StringLength(400, MinimumLength = 3)]
        public string? Answer { get; set; }

}
}
