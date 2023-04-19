using BackModelTask.DataAccess;
using BackModelTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using BackModelTask.Models;
using System.Collections.Generic;

namespace BackModelTask.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Index()
        {

            StudentViewModel studentViewModel = new StudentViewModel()
            {
                Groups = Data.groups,
                Students = Data.students,
            };

            return View(studentViewModel);
        }

        public ViewResult Detail(int id)
        {

            List<Student> students = Data.students;

            Student std=students.Find(x => x.id == id);



            return View(std);
        }
    }
}
