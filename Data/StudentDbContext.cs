using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssesment.Data
{
    public class StudentDbContext:DbContext
    {
        #region constructor        
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }
        #endregion constructor

        #region public properties
        public DbSet<Students> Student { get; set; }
        public DbSet<classes> Classes { get; set; }
        public DbSet<country> Country { get; set; }
        #endregion

        #region overriden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>().HasData(GetStudents());
            modelBuilder.Entity<classes>().HasData(GetClasses());
            modelBuilder.Entity<country>().HasData(GetCountries());
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region private methods
        private List<Students> GetStudents()
        {
            return new List<Students>
            {
                new Students{ id = 1001, name = "Anoob", class_id=1, country_id=101, date_of_birth = DateTime.Now }
            };
        }

        private List<classes> GetClasses()
        {
            return new List<classes>
            {
                new classes{ id = 1, class_name = "First Standard" }
            };
        }

        private List<country> GetCountries()
        {
            return new List<country>
            {
                new country{ id = 101, country_name = "India" }
            };
        }
        #endregion
    }
}
