using AndenTest.Common.Entity;

namespace AndenTest.IServices
{
    public interface IFormAService
    {
        /// <summary>
        /// Deletes a form
        /// </summary>
        /// <param name="formA"></param>
        /// <returns></returns>
        public Task<bool> DeleteFormAAsync(FormA formA);

        /// <summary>
        /// Gets all forms
        /// </summary>
        /// <returns></returns>
        public Task<List<FormA>> GetAllFormsAAsync();

        /// <summary>
        /// Get a form by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<FormA?> GetFormAAsync(int id);

        /// <summary>
        /// Inserts one form to the DB
        /// </summary>
        /// <param name="formA"></param>
        /// <returns></returns>
        public Task<FormA?> InsertFormAAsync(FormA formA);

        /// <summary>
        /// Updates one form
        /// </summary>
        /// <param name="formA"></param>
        /// <returns></returns>
        public Task<bool> UpdateFormAAsync(FormA formA);
    }
}