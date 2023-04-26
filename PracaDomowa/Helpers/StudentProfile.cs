using AutoMapper;
using PracaDomowa.Models;

namespace PracaDomowa.Helpers
{
    public class StudentProfile :Profile
    {
        public StudentProfile()
        {
            CreateMap<StudetHelper, Student>();
            //.ReverseMap();  Jezeli chcemy odwrócić




        }



    }
}
