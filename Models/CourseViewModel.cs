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

        [Required(ErrorMessage = "Please select a service.")]
        public string SelectCourse { get; set; }

        [Required(ErrorMessage = "Please select start date.")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "ntext")]
        [StringLength(90000000, ErrorMessage = "Massege must be at least 10 characters long.", MinimumLength = 10)]
        public string Message { get; set; }

        [Required(ErrorMessage = "You must agree before submitting.")]
        public Boolean CheckStudy { get; set; } = false;
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