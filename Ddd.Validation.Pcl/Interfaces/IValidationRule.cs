namespace Ddd.Validation.Interfaces
{
    /// <summary>
    /// It provides a set of methods to build a validation rule
    /// </summary>
    /// <typeparam name="TEntity">The entity to be validated</typeparam>
    public interface IValidationRule<in TEntity>
    {
        /// <summary>
        /// The error message associated to the rule
        /// </summary>
        string ErrorMessage { get; }

        /// <summary>
        /// Validate the entity
        /// </summary>
        /// <param name="entity">The entity</param>
        /// <returns>True if the entity is valid</returns>
        bool Valid(TEntity entity);
    }
}