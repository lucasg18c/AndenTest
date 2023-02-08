using AndenTest.Common.Entity;
using AndenTest.IServices;
using AndenTest.Persistence;
using Microsoft.EntityFrameworkCore;

namespace AndenTest.Services
{
    public class FormAService : Service, IFormAService
    {
        public FormAService(AndenDBContext dBContext) : base(dBContext) { }

        /// <summary>
        /// Deletes a form
        /// </summary>
        /// <param name="formA"></param>
        /// <returns></returns>
        public async Task<bool> DeleteFormAAsync(FormA formA)
        {
            try
            {
                context.FormsA.Remove(formA);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Log(ex);
                return false;
            }
        }

        /// <summary>
        /// Gets all forms
        /// </summary>
        /// <returns></returns>
        public Task<List<FormA>> GetAllFormsAAsync()
        {
            try
            {
                return context.FormsA.ToListAsync();
            }
            catch (Exception ex)
            {
                Log(ex);
                return Task.FromResult(new List<FormA>());
            }
        }

        /// <summary>
        /// Get a form by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<FormA?> GetFormAAsync(int id)
        {
            try
            {
                return await context.FormsA.FirstOrDefaultAsync(f => f.FormID == id);
            }
            catch (Exception ex)
            {
                Log(ex);
                return null;
            }
        }

        /// <summary>
        /// Inserts one form to the DB
        /// </summary>
        /// <param name="formA"></param>
        /// <returns></returns>
        public async Task<FormA?> InsertFormAAsync(FormA formA)
        {
            try
            {
                var res = context.FormsA.Add(formA);
                var written = await context.SaveChangesAsync();

                if (written == 0 || res is null)
                {
                    return null;
                }

                return res.Entity;
            }
            catch (Exception ex)
            {
                context.FormsA.Remove(formA);
                Log(ex);
                return null;
            }
        }

        /// <summary>
        /// Updates one form
        /// </summary>
        /// <param name="formA"></param>
        /// <returns></returns>
        public async Task<bool> UpdateFormAAsync(FormA formA)
        {
            try
            {
                var res = context.FormsA.Update(formA);
                await context.SaveChangesAsync();
                return res.State == EntityState.Modified;
            }
            catch (Exception ex)
            {
                Log(ex);
                return false;
            }
        }
    }
}
