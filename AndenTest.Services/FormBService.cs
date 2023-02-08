using AndenTest.Common.Entity;
using AndenTest.IServices;
using AndenTest.Persistence;
using Microsoft.EntityFrameworkCore;

namespace AndenTest.Services
{
    public class FormBService : Service, IFormBService
    {
        public FormBService(AndenDBContext dBContext) : base(dBContext) { }

        public async Task<bool> DeleteFormBAsync(FormB form)
        {
            try
            {
                context.FormsB.Remove(form);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Log(ex);
                return false;
            }
        }

        public Task<List<FormB>> GetAllFormsBAsync()
        {
            try
            {
                return context.FormsB.ToListAsync();
            }
            catch (Exception ex)
            {
                Log(ex);
                return Task.FromResult(new List<FormB>());
            }
        }


        public async Task<FormB?> GetFormBAsync(int id)
        {
            try
            {
                return await context.FormsB.FirstOrDefaultAsync(f => f.FormID == id);
            }
            catch (Exception ex)
            {
                Log(ex);
                return null;
            }
        }

        public async Task<FormB?> InsertFormBAsync(FormB form)
        {
            try
            {
                var res = context.FormsB.Add(form);
                var written = await context.SaveChangesAsync();

                if (written == 0 || res is null)
                {
                    return null;
                }

                return res.Entity;
            }
            catch (Exception ex)
            {
                context.FormsB.Remove(form);
                Log(ex);
                return null;
            }
        }

        public async Task<bool> UpdateFormBAsync(FormB form)
        {
            try
            {
                var res = context.FormsB.Update(form);
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
