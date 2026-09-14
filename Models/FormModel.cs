using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class FormModel
    {
        [Required(ErrorMessage = "Le nom est obligatoire.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Le prénom est obligatoire.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Veuillez sélectionner un sexe.")]
        public string Gender { get; set; } = string.Empty;

        [Required(ErrorMessage = "L'adresse est obligatoire.")]
        [MinLength(5, ErrorMessage = "L'adresse doit contenir au moins 5 caractères.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Le code postal est obligatoire.")]
        [RegularExpression(@"^\d{5}$",
            ErrorMessage = "Le code postal doit contenir exactement 5 chiffres.")]
        public string ZipCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "La ville est obligatoire.")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "L'adresse mail est obligatoire.")]
        [EmailAddress(ErrorMessage = "Le format de l'adresse mail est incorrect.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La date de début est obligatoire.")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "Veuillez sélectionner une formation.")]
        public string TrainingType { get; set; } = string.Empty;

        public string? CobolOpinion { get; set; }

        public string? CSharpOpinion { get; set; }
    }
}