using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace CursoAula.Models
{
    [Table("Aula")]
    public class Aula
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título da aula deve ser preenchido.")]
        [MaxLength(50, ErrorMessage = "O título da aula deve ter até 50 caracteres.")]
        [MinLength(10, ErrorMessage = "O título da aula de ter ao menos 10 caracteres")]
        public string Titulo { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "A ordem da aula deve ser maior que zero.")]
        public int Ordem { get; set; }

        [JsonIgnore]
        [ForeignKey("Curso")]
        public int IdCurso { get; set; }

        [JsonIgnore]
        public virtual Curso Curso { get; set; }
    }
}