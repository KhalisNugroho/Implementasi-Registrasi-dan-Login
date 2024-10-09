using System;
using SecureWeb.Models; //Gatau bener engga

namespace SecureWeb.Data;

public interface IStudents
{
    IEnumerable<Students> GetStudents();
    Students GetStudents(String nim);
    Students AddStudents(Students students);
    Students UpdateStudents(Students students);
    void DeleteStudents(string nim);
}
