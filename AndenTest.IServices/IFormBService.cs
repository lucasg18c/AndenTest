using AndenTest.Common.Entity;

namespace AndenTest.IServices
{
    public interface IFormBService
    {
        /// <summary>
        /// Deletes a form
        /// </summary>
        /// <param name="formA"></param>
        /// <returns></returns>
        public Task<bool> DeleteFormBAsync(FormB formB);

        /// <summary>
        /// Gets all forms
        /// </summary>
        /// <returns></returns>
        public Task<List<FormB>> GetAllFormsBAsync();

        /// <summary>
        /// Get a form by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<FormB?> GetFormBAsync(int id);

        /// <summary>
        /// Inserts one form to the DB
        /// </summary>
        /// <param name="formA"></param>
        /// <returns></returns>
        public Task<FormB?> InsertFormBAsync(FormB formB);

        /// <summary>
        /// Updates one form
        /// </summary>
        /// <param name="formA"></param>
        /// <returns></returns>
        public Task<bool> UpdateFormBAsync(FormB formB);
    }
}