using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Models.Domain
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string City { get; set; } = default!;
        public string PinCode { get; set; } = default!;
        public string State { get; set; } = default!;
    }
}
