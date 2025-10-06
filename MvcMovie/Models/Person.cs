using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        [Column("Id")]
        public int PersonId { get; set; } = default!;
        public string FullName { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string email { get; set; } = default!;
    }
}