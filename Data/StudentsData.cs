using System;
using SecureWeb.Models;

namespace SecureWeb.Data;

public class StudentsData : IStudents
{
    private readonly ApplicationDbContext _db;

    public StudentsData(ApplicationDbContext db)
    {
        _db=db;
    }
    public Students AddStudents(Students students)
    {
        try
        {
            _db.Students.Add(students);
            _db.SaveChanges();
            return students;
        }
        catch (System.Exception ex)
        {
            
            throw new Exception(ex.Message);
        }
    }

    public void DeleteStudents(string nim)
    {
        throw new NotImplementedException();
    }

    public Students GetStudents(string nim)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Students> GetStudents()
    {
        var students = _db.Students.OrderBy(s => s.FullName);
        return students;
    }
    
    public Students UpdateStudents(Students students)
    {
        throw new NotImplementedException();
    }
}