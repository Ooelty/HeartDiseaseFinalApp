using System.ComponentModel.DataAnnotations;

namespace HeartDiseaseAPI.Dtos
{
    public class PatientInputDto
    {
        [Required]
        [Range(1,120, ErrorMessage = "Age entre 1 et 120")]
        public int Age { get; set; }

        [Required]
        [RegularExpression("^(F|f|M|m)$")]
        public string Sex { get; set; } = "M";

        [Required]
        [Range(0, 300, ErrorMessage = "Taille entre 0 et 300 cm")]
        public int Height { get; set; }

        [Required]
        [Range(30, 300, ErrorMessage ="poids entre 30 et 300 kg")]
        public int Weight { get; set; }

        [Required]
        [Range(30, 250, ErrorMessage = "tension diastolique entre 30 et 250")]
        public float BloodPressureLow { get; set; }

        [Required]
        [Range(50, 300, ErrorMessage = "tension systolique entre 50 et 300")]
        public float BloodPressureHigh { get; set; }

        [Required]
        [Range(50,400, ErrorMessage = "cholesterol entre 50 et 400")]
        public float Cholesterol { get; set; }

        [Required]
        [Range(30,600, ErrorMessage = "glucose entre 30 et 600")]
        public float Glucose { get; set; }

        public bool IsSmoker { get; set; }
        public bool IsAlcoholic { get; set; }
        public bool IsActive { get; set; }
    }
}