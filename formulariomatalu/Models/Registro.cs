using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace formulariomatalu.Models
{

    [Table("t_alumno")]
    public class Registro
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        [Column("apellidos")]
        public string Apellidos { get; set;}

        [Column("nombres")]
        public string Nombres { get; set;}

        public DateTime FechaNacimiento { get; set;}

        [Column("dni")]
        public int Dni { get; set;}

        [Column("genero")]
         public string Genero { get; set; }

         [Column("carrera")]
        public string Carrera { get; set;}
    }
}