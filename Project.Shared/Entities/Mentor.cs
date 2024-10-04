using System.ComponentModel.DataAnnotations;

namespace Project.Shared.Entities
{
    public class Mentor
    {
        public int Id { get; set; }

        [Display(Name = "Name Mentor")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NameMentor { get; set; }

        [Display(Name = "Area experience")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string AreaExp { get; set; }

        //equipos asignados -- entidad Equipos
        //proyectos supervisados -- Plan



    }
}
