using System.ComponentModel.DataAnnotations;

namespace Project.Shared.Entities
{
    public class Team
    {
        public int Id { get; set; }

        [Display(Name = "Name Team")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NameTe { get; set; }

        [Display(Name = "Number of members")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NumberMem { get; set; }

        [Display(Name = "Experience")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string ExperienceTeam { get; set; }

        [Display(Name = "Role")]
        [MaxLength(200, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string RoleTeam { get; set; }

    }
}
