using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace demomvc.Models
{
    [Table("t_contacto")]
    public class Contacto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public string Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Name {get; set;}
        public string Comment {get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }

    }
}