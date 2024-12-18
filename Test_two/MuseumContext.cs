using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_two
{
    public class MuseumContext : DbContext
    {
        public DbSet<Exhibit> Exhibits { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<ExhibitionExhibit> ExhibitionExhibits { get; set; }

        public MuseumContext() : base("name=MuseumDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExhibitionExhibit>()
                .HasRequired(ee => ee.Exhibit)
                .WithMany(e => e.ExhibitionExhibits)
                .HasForeignKey(ee => ee.ExhibitId);

            modelBuilder.Entity<ExhibitionExhibit>()
                .HasRequired(ee => ee.Exhibition)
                .WithMany(e => e.ExhibitionExhibits)
                .HasForeignKey(ee => ee.ExhibitionId);
        }
    }
}
