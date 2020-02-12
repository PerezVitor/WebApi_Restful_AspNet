using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CursoAula.Models
{
    [Table("Curso")]
    public class Curso
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título do curso deve ser preenchido.")]
        [MaxLength(100, ErrorMessage = "O título do curso deve conter menos de 100 caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O canal do curso deve ser preenchido.")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Canal Canal { get; set; }

        [Required(ErrorMessage = "A data de publicação do curso deve ser preenchida.")]
        public DateTime DataPublicacao { get; set; }

        [Required(ErrorMessage = "A carga horária do curso deve ser preenchida.")]
        [Range(1, Int32.MaxValue, ErrorMessage = "A carga horária deve ser de pelo menos 1h.")]
        public int CargaHoraria { get; set; }

        [JsonIgnore]
        public virtual ICollection<Aula> Aulas { get; set; }
    }
}