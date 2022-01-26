using System;
using System.ComponentModel;

namespace Finest.Models
{
    public class FinestModel
    {
        [DisplayName("Numer")]
        public int Id { get; set; }
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Opis")]
        public string Description { get; set; }
        [DisplayName("Data realizacji")]
        public DateTime Date { get; set; }
        [DisplayName("Zadanie ukończone")]
        public bool Completed { get; set; }
    }
}
