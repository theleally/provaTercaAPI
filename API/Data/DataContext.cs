using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Data
{
    public class DataContext : DbContext
    {
        // Construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // Lista de propriedades que vão virar tabelas no banco
        public DbSet<Automovel> Automovel { get; set; }
    }
}