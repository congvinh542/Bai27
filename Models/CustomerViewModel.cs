    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CustomerViewModel
    {
        [Required(ErrorMessage = "FullName cannot be blank!")]
        [StringLength(50, ErrorMessage = "Full name must be at least 3 characters long.",MinimumLength = 3)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email cannot be blank!")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Please enter a valid email adress.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone cannot be blank!")]
        [StringLength(12, ErrorMessage = "Phone number must be 10-12 digits.", MinimumLength = 10 )]
        public string Phone { get; set; }

        public string Address { get; set; }

        [Column(TypeName = "ntext")]
        [StringLength(90000000, ErrorMessage = "Massege must be at least 10 characters long.", MinimumLength = 10)]
        public string Message { get; set; }

        [Required(ErrorMessage = "Please select a service.")]
        public string SelectService { get; set; }

        [Required(ErrorMessage = "You must agree before submitting.")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree before submitting.")]
        public Boolean Check { get; set; }
    }

    public class SelectServices
    {
        public int Id {get;set;}
        public string Name {get;set;}
    }

    public static class ListSelectService
    {
        public static List<SelectServices> Values = new List<SelectServices>();
        static ListSelectService() {
            Values.Add(new SelectServices { Id = 1,Name="Tư vấn"});
            Values.Add(new SelectServices { Id = 2,Name="Lắp đặt"});
            Values.Add(new SelectServices { Id = 3,Name="Bảo trì"});
            Values.Add(new SelectServices { Id = 4,Name="Chính sách bảo hành"});
        }
        public static void AddServices(SelectServices newServices)
        {
            Values.Add(newServices);
        }
    }