using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salud.BD.Data.Entity
{
    [Index(nameof(CodProfesion), Name = "Profesion_Cod_UQ", IsUnique = true)]
    public class Profesion: EntityBase
    {
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [MaxLength(4, ErrorMessage = "En el {0} usar como máximo {1} caracteres")]
        [Display(Name = "Código")]
        public string CodProfesion { get; set;}

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "En el {0} usar como máximo {1} caracteres")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
    }
}
