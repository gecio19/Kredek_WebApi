using System.ComponentModel.DataAnnotations;

namespace PracaDomowa.Models;

public class Student
{

    public Student()
    {

    }


    public Student(int id,string name, string surname,string specialization)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Specialization = specialization;
    }


    [Key]
    public int Id { get; set; }



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



