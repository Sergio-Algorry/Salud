using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salud.BD.Data.Entity
{
    [Index(nameof(PersonaId), nameof(ProfesionId), Name = "Persona_Profesion_UQ", IsUnique = true)]
    public class Titulo : EntityBase
    {
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public int PersonaId { get; set; }

        public Persona Persona { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        public int ProfesionId { get; set; }

        public Profesion Profesion { get; set; }
    }
}
