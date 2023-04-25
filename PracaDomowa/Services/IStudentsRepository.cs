using PracaDomowa.Models;

namespace PracaDomowa.Repositories
{
    public interface IStudentsRepository
    {
        int AddStudent(Student student);

        IEnumerable<Student> GetAll();

        Student GetStudentByID(int id);

        bool DeleteStudent(int id);

        bool UpdateStudent(int id, Student student);











    }
}
