using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finest.Models
{
    [Table("Finests")]
    public class FinestModel
    {
        [DisplayName("Numer")]
        [Key]
        public int Id { get; set; }
        [DisplayName("Nazwa")]
        [Required(ErrorMessage ="Wpisz nazwę zadania")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DisplayName("Opis")]
        [MaxLength(2500)]
        public string Description { get; set; }
        [DisplayName("Data realizacji")]
        public DateTime Date { get; set; }
        [DisplayName("Zadanie ukończone")]
        public bool Completed { get; set; }
    }
}
