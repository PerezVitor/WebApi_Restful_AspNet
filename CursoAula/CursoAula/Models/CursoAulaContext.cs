using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CursoAula.Models
{
    public class CursoAulaContext : DbContext
    {
        public CursoAulaContext() : base("CursoAulaDB")
        { 
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Aula> Aulas { get; set; }
    }
}