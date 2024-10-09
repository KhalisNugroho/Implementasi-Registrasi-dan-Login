using System;
using Microsoft.AspNetCore.Mvc;
using SecureWeb.Data;
using SecureWeb.Models; // Add this line to import the Students model

namespace SecureWeb.Controllers;

public class StudentsController : Controller
{
    private readonly IStudents _studentsData;
    public StudentsController(IStudents studentsData)
    {
        _studentsData = studentsData;
    }

    public IActionResult Index()
    {
        var students = _studentsData.GetStudents();
        return View(students); // Pass the students to the view
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Students students) // Change Student to Students
    {
        try
        {
            _studentsData.AddStudents(students); 
            return RedirectToAction("Index"); 
        }
        catch (System.Exception ex)
        {
            ViewBag.Error = ex.Message;
        }
        return View(students); 
    }

    public IActionResult Edit()
    {
        return View();
    }

}
