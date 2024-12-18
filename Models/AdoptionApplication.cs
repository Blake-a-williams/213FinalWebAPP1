using System.ComponentModel.DataAnnotations;

namespace Blazor213FinalWebAPP.Models
{
    public class AdoptionApplication
{
        public int Id { get; set; }
        public int DogId { get; set; }
        public int UserId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string? FullName { get; set; }

        [Required]
        public DateTime UserAge { get; set; }= DateTime.Now;

        [Required]
        [StringLength(55, MinimumLength = 5)]
        public string? Email { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 2)]
        public string? Phone { get; set; }

        [Required]
        [StringLength(120, MinimumLength = 2)]
        public string? Address { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string? City { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string? State { get; set; }

        [Required]
        public string? Employed { get; set; }

        [StringLength(40)]
        public string? EmploymentOccupation { get; set; }

        
        public string? EmploymentEmployer { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string? HouseType { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string? Rent {  get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string? Yard { get; set; }

        public string? YardDetails { get; set; }

        [Required]
        [StringLength(55, MinimumLength = 2)]
        public string? Residents { get; set; }

        public string? ResidentsUnder21 { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string? RefName { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 2)]
        public string? RefNumber { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string? RefRelationship { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string? RefName2 { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 2)]
        public string? RefNumber2 { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string? RefRelationship2 { get; set; }

        [Required]
        public string? CurrentPets { get; set; }

        public string? CurrentPetsInfo { get; set; }

        [Required]
        public string? PastPets { get; set; }

        public string? PastPetsInfo { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 2)]
        public string? ReasonForAdoption { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string? DogName { get; set; }

        [Required]
        [StringLength(400, MinimumLength = 5)]
        public string? Fit {  get; set; }

        [Required]
        [StringLength(150, MinimumLength = 2)]
        public string? Training {  get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string? DogHomeAlone { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string? Sleep { get; set; }

        public string? Other { get; set; }
       // public string Status { get; set; } = "Pending";
        public DateTime SubmissionDate { get; set; } = DateTime.Now;
    }
}
