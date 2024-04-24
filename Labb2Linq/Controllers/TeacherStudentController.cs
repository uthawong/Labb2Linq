using Labb2Linq.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Labb2Linq.Controllers
{
    public class TeacherStudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeacherStudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> AllStudents()
        {
            var students = _context.Students.Include(s => s.Class);
            return View(await students.ToListAsync());
        }

        public async Task<IActionResult> TeacherByCourse()
        {
            var enrollment = _context.Enrollments
                .Include(e => e.Teacher)
                .Include(e => e.Course);
            return View(await enrollment.ToListAsync());

            //var enrollment = _context.Enrollments
            //.Include(s => s.Teacher)
            //.Include(s => s.Course)
            //.ToListAsync();

            //return View(enrollment);

        }
        public async Task<IActionResult> StudentByCourse()
        {
            var enrollment = _context.Enrollments
                .Include(s => s.Student)
                .Include(s => s.Course);
            return View(await enrollment.ToListAsync());
        }


        //public async Task<IActionResult> StudentByCourse()
        //{
        //    var enrollment = _context.Enrollments.Include(s => s.Course);
        //    return View(await enrollment.ToListAsync());
        //}
    }
}