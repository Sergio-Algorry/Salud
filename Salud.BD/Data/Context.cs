using Microsoft.EntityFrameworkCore;
using Salud.BD.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salud.BD.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Profesion> Profesiones { get; set; }


    }
}
