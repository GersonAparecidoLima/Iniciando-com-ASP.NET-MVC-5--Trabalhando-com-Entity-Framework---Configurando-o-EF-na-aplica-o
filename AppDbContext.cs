using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Paramentro.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Paramentro.Data
{
    public class AppDbContext : DbContext
    {
        // O objetico do DbContext e mapea as clasee para que ela 
        // se torne banco de dados
        // E o DbSet ser para mapea a classe aluno

        //DefaultConnection vai ser o  name="DefaultConnection" no  connectionStrings do web config
        public AppDbContext() :base(nameOrConnectionString: "DefaultConnection")
        {

        }

        //Mapeando a classe aluno
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //******************************************
            //para o Entity não aplicar o plural
            //******************************************

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Aluno>().ToTable("Alunos");
            base.OnModelCreating(modelBuilder);
        }


    }
}