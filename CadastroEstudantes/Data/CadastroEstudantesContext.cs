using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroEstudantes.Models;

namespace CadastroEstudantes.Data
{
    public class CadastroEstudantesContext : DbContext
    {
        public CadastroEstudantesContext (DbContextOptions<CadastroEstudantesContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroEstudantes.Models.Estudante> Estudante { get; set; } = default!;
    }
}
