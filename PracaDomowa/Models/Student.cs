using System.ComponentModel.DataAnnotations;

namespace PracaDomowa.Models;

public class Student
{

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(6)]
    public int AlbumNumber { get; set; }

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



