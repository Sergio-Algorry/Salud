using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salud.BD.Data.Entity
{
    [Index(nameof(Cod), Name = "TipoDocumento_Cod_UQ", IsUnique = true)]
    public class TipoDocumento : EntityBase
    {
        [Required(ErrorMessage = "El {0} del Tipo de Documento es obligatorio")]
        [MaxLength(4,ErrorMessage = "En el {0} usar como máximo {1} caracteres")]
        [Display(Name = "Código")]
        public string Cod { get; set; }

        [Required(ErrorMessage = "La DESCRIPCIÓN del Tipo de Documento es obligatoria")]
        [MaxLength(100, ErrorMessage = "Usar como máximo 100 caracteres")]
        public string Descripcion { get; set; }

        public List<Persona> Personas { get; set; }
    }
}
