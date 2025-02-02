using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bai27.Models
{
    public class CourseViewModel
    {
        [Required(ErrorMessage = "FullName cannot be blank!")]
        [StringLength(50, ErrorMessage = "Full name must be at least 3 characters long.", MinimumLength = 3)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email cannot be blank!")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Please enter a valid email adress.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone cannot be blank!")]
        [StringLength(12, ErrorMessage = "Phone number must be 10-12 digits.", MinimumLength = 10)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please select a course.")]
        public string SelectCourse { get; set; }

        [Required(ErrorMessage = "Please select start date.")]
        [Range(typeof(DateTime), "1/1/2000", "12/31/2100", ErrorMessage = "Please select a valid start date.")]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Column(TypeName = "ntext")]
        public string Message { get; set; }

        public string CheckStudy { get; set; } = "";
        [Required(ErrorMessage = "You must agree before submitting.")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree before submitting.")]
        public Boolean Check { get; set; } = false;
    }

    public class SelectCourses
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public static class ListSelectCourse
    {
        public static List<SelectCourses> Values = new List<SelectCourses>();
        static ListSelectCourse()
        {
            Values.Add(new SelectCourses { Id = 1, Name = "Full Stact Dot net" });
            Values.Add(new SelectCourses { Id = 2, Name = "React Native" });
            Values.Add(new SelectCourses { Id = 3, Name = "Lập trình Font-End master ReactJs" });
            Values.Add(new SelectCourses { Id = 4, Name = "Lập trình Back-End Java" });
        }
        public static void AddServices(SelectCourses newServices)
        {
            Values.Add(newServices);
        }
    }
}