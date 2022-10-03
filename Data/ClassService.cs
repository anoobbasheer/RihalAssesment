using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssesment.Data
{
    public class ClassService
    {
        #region private member
        private StudentDbContext dbContext;
        #endregion

        #region constructor
        public ClassService(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region methods
        public async Task<List<classes>> GetClassesAsync()
        {
            return await dbContext.Classes.ToListAsync();
        }

        public async Task<classes> AddClassAsync(classes cls)
        {
            try
            {
                dbContext.Classes.Add(cls);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }

            return cls;
        }

        public async Task<classes> updateClassesAsync(classes cls)
        {
            try
            {
                var classList = dbContext.Classes.FirstOrDefault(p => p.id == cls.id);

                if (classList != null)
                {
                    dbContext.ChangeTracker.Clear();
                    dbContext.Update(cls);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return cls;
        }

        public async Task DeleteClassesAsync(classes cls)
        {
            try
            {
                dbContext.ChangeTracker.Clear();
                dbContext.Classes.Remove(cls);
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
