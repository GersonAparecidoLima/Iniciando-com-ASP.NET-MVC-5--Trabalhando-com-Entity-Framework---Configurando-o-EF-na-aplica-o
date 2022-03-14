namespace Paramentro.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;
    internal sealed class Configuration : DbMigrationsConfiguration<Paramentro.Data.AppDbContext>
    {
        public Configuration()
        {
            //********************************************************
            //Para pode aplicar as Migradio dever esta setada com true
            //********************************************************
            AutomaticMigrationsEnabled = true;
        }


        protected override void Seed(Paramentro.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

    }
}
