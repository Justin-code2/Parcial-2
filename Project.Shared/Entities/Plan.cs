using System.ComponentModel.DataAnnotations;

namespace Project.Shared.Entities
{
    public class Plan
    {
        public int Id { get; set; }

        [Display(Name = "Name Project")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NamePro { get; set; }

        [Display(Name = "Description project")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string DescripPro { get; set; }

        [Display(Name = "State")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string StatePro { get; set; }

        [Display(Name = "End Date")]
        [MaxLength(200, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string DateEnd { get; set; }

        //equipo que lo desarrollo -- entidad Team
        //mentor asignado -- entidad Mentor

    }
}