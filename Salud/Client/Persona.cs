using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salud.BD.Data.Entity
{
    [Index(nameof(TipoDocumentoId), nameof(NumDoc), Name = "Persona_TD_DNI_UQ", IsUnique = true)]
    public class Persona : EntityBase
    {

        [Required(ErrorMessage = "El {0} es obligatorio")]
        public int TipoDocumentoId { get; set; }

        public TipoDocumento TipoDocumento { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [MaxLength(9, ErrorMessage = "En el {0} usar como máximo {1} caracteres")]
        [Display(Name = "Núm.Doc.")]
        public string NumDoc { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "En el {0} usar como máximo {1} caracteres")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "En el {0} usar como máximo {1} caracteres")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        public List<Titulo> Titulos { get; set; }

        public List<Matricula> Matriculas { get; set; }
    }
}
