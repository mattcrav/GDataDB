
namespace GDataDB {
    /// <summary>
    /// Google spreadsheet service entry point
    /// </summary>
    public interface IDatabaseClient {

        /// <summary>
        /// Creates a new <see cref="IDatabase"/> (spreadsheet document)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IDatabase CreateDatabase(string name);

        /// <summary>
        /// Gets an existing <see cref="IDatabase"/> (spreadsheet document)
        /// </summary>
        /// <param name="name"></param>
        /// <returns>IDocument instance or null if not found</returns>
        IDatabase GetDatabase(string name);
    }
}