using System.ComponentModel.DataAnnotations;

namespace PracaDomowa.Helpers
{
    public class StudetHelper
    {
        public StudetHelper( string name, string surname, string specialization)
        {
            Name = name;
            Surname = surname;
            Specialization = specialization;
        }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(100)]
        public string Specialization { get; set; }



    }
}
