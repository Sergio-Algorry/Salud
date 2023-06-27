using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salud.BD.Data.Entity
{
    [Index(nameof(CodEspecialidad), Name = "Especialidad_Cod_UQ", IsUnique = true)]
    public class Especialidad : EntityBase
    {
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public int ProfesionId { get; set; }

        public Profesion Profesion { get; set; }

        [Required(ErrorMessage = "El {0} del Código de la especialidad es obligatorio")]
        [MaxLength(4, ErrorMessage = "En el {0} usar como máximo {1} caracteres")]
        [Display(Name = "Código")]
        public string CodEspecialidad { get; set; }

        [Required(ErrorMessage = "La DESCRIPCIÓN de la especialidad es obligatoria")]
        [MaxLength(100, ErrorMessage = "Usar como máximo 100 caracteres")]
        public string DescEspecialidad { get; set; }

        public List<Matricula> Matriculas { get; set; }
    }
}
