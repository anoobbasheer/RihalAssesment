using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssesment.Data
{
    public class CountryService
    {
        #region private member
        private StudentDbContext dbContext;
        #endregion

        #region constructor
        public CountryService(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region methods
        public async Task<List<country>> GetCountryAsync()
        {
            return await dbContext.Country.ToListAsync();
        }

        public async Task<country> AddCountryAsync(country country)
        {
            try
            {
                dbContext.Country.Add(country);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }

            return country;
        }

        public async Task<country> updateCountryAsync(country country)
        {
            try
            {
                var classList = dbContext.Country.FirstOrDefault(p => p.id == country.id);

                if (classList != null)
                {
                    dbContext.ChangeTracker.Clear();
                    dbContext.Update(country);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return country;
        }

        public async Task DeleteCountryAsync(country country)
        {
            try
            {
                dbContext.ChangeTracker.Clear();
                dbContext.Country.Remove(country);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        #endregion
    }
}
