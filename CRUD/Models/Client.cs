using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        [Column("id")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Column("name")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Column("birthdate")]
        [Display(Name = "Birth Date")]
        public DateTime Birthdate { get; set; }

        [Column("active")]
        [Display(Name = "Active")]
        public bool Active { get; set; }
    }
}
