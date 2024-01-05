using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Models.Domain
{
    public class Skills
    {
        [Key]
        public int Id { get; set; }
        public string SkillName { get; set; } = default!;
    }
}
