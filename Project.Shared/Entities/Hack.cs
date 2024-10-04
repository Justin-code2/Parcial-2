using System.ComponentModel.DataAnnotations;

namespace Project.Shared.Entities
{
    public class Hack
    {
        public int Id { get; set; }

        [Display(Name = "Name Hackaton")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NameHack { get; set; }

        [Display(Name = "Start Date")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string DateStart { get; set; }

        [Display(Name = "End Date")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string DateEnd { get; set; }

        [Display(Name = "Topic")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Topic { get; set; }

        [Display(Name = "Organizer")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Organizer { get; set; }



    }
}
