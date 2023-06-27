using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salud.BD.Data.Entity
{
    [Index(nameof(EspecialidadId), nameof(PersonaId), Name = "Especialidad_Persona_UQ", IsUnique = true)]
    public class Matricula : EntityBase
    {
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        public int EspecialidadId { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [MaxLength(4, ErrorMessage = "En el {0} usar como máximo {100} caracteres")]
        [Display(Name = "Número de la matrícula")]
        public string NumMatricula { get; set; }

        public decimal PagoDecimal { get; set; }
    }
}
