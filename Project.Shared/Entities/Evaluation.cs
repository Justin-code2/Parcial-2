using System.ComponentModel.DataAnnotations;

namespace Project.Shared.Entities
{
    public class Evaluation
    {
        public int Id { get; set; }

        [Display(Name = "Score")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Score { get; set; }

        [Display(Name = "Mentor comment")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string CommentMent { get; set; }

        //proyecto evaluado -- entidad Plan
        //mentor evaluado -- entidad Mentor

    }
}
