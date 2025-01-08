using System.ComponentModel.DataAnnotations;

namespace errors_check
{
    public class Department
    {
        [Key]
        public string Name { get; set; }
    }
}
