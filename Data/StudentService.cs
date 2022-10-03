using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RihalAssesment.Data
{
    public class StudentService
    {
        #region private member
        private StudentDbContext _dbContext;
        #endregion

        #region constructor
        public StudentService(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region methods
        /// <summary>
        /// GetStudentsAsync
        /// </summary>
        /// <returns></returns>
        public async Task<List<Students>> GetStudentsAsync()
        {
            return await _dbContext.Student.ToListAsync();
        }

        /// <summary>
        /// AddStudentAsync
        /// </summary>
        /// <param name="std"></param>
        /// <returns></returns>
        public async Task<Students> AddStudentAsync(Students std)
        {
            try
            {
                _dbContext.Student.Add(std);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }

            return std;
        }

        /// <summary>
        /// updateStudentAsync
        /// </summary>
        /// <param name="std"></param>
        /// <returns></returns>
        public async Task<Students> updateStudentAsync(Students std)
        {
            try
            {
                var studentList = _dbContext.Student.FirstOrDefault(p => p.id == std.id);

                if(studentList != null)
                {
                    _dbContext.ChangeTracker.Clear();
                    _dbContext.Student.Update(std);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return std;
        }

        /// <summary>
        /// DeleteStudentAsync
        /// </summary>
        /// <param name="std"></param>
        /// <returns></returns>
        public async Task DeleteStudentAsync(Students std)
        {
            try
            {
                _dbContext.ChangeTracker.Clear();
                _dbContext.Student.Remove(std);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        #endregion
    }
}
