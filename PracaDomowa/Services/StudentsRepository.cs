using AutoMapper;
using PracaDomowa.Data;
using PracaDomowa.Helpers;
using PracaDomowa.Models;

namespace PracaDomowa.Repositories
{
    public class StudentsRepository : IStudentsRepository
    {
        private  DatabaseContext _context;
        private readonly IMapper _mapper;




        public StudentsRepository(DatabaseContext context,IMapper mapper)
        {
            _context= context;
            _mapper= mapper;
        }



        public int AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

            return student.Id;
        }





        public bool DeleteStudent(int id)
        {
            var studentToDelete = _context.Students.Find(id);
            if (studentToDelete is null) 
            {
                return false;
            }
            _context.Students.Remove(studentToDelete);
            _context.SaveChanges() ;
            return true;
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }


        public bool UpdateStudent(int id,StudetHelper student)
        {
            var studentToUpdate = _context.Students.Find(id);

            if (studentToUpdate is null) 
            { 
                return false;
            }
            _mapper.Map<StudetHelper,Student>(student, studentToUpdate);
            _context.SaveChanges();
            /* studentToUpdate.Id = id;
             studentToUpdate.Name = student.Name;
             studentToUpdate.Surname = student.Surname;
             studentToUpdate.Specialization = student.Specialization;
             _context.SaveChanges();
 */
            return true;
        }



        public Student GetStudentByID(int id)
        {
            var result = _context.Students.FirstOrDefault(s => s.Id == id);
            return result;
        }





    }
}
