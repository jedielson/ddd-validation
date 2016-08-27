namespace Ddd.Validation.Interfaces
{
    /// <summary>
    /// It provides a set of methods to build a simple validation
    /// </summary>
    /// <typeparam name="TEntity">The type of entity</typeparam>
    public interface IValidation<in TEntity>
    {
        /// <summary>
        /// Validate an entity
        /// </summary>
        /// <param name="entity">The entity</param>
        /// <returns>A <see cref="IValidationResult"/></returns>
        IValidationResult Valid(TEntity entity);
    }
}