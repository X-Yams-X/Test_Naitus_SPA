using TestNaitus.Domains;

namespace TestNaitus.Infrastructure
{
    public interface IUserRepository
    {
        /// <summary>
        /// Metodo que crea un nuevo usuario
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        Task<User?> CreateAsync(User u);

        /// <summary>
        /// Metodo que obtiene todos los usuarios
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<User>> RetrieveAllAsync();

        /// <summary>
        /// Metodo que obtiene un usuario por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<User?> RetrieveAsync(string id);

        /// <summary>
        /// Metodo que actualiza el usuario
        /// </summary>
        /// <param name="id"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        Task<User?> UpdateAsync(string id, User c);
        
        /// <summary>
        /// Metodo que Elimina un usuario 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<User?> DeleteAsync(string id);
    }
}