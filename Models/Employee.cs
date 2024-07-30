using System.ComponentModel.DataAnnotations;

namespace CRUDAPI.Models
{
    public class Employee
    {
        [Key]
        public int ID {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int IsActive { get; set; }
    }
}
