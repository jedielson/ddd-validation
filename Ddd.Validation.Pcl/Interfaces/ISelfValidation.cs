namespace Ddd.Validation.Interfaces
{
    /// <summary>
    /// It provides a set of methods that an entity can validate itself
    /// </summary>
    public interface ISelfValidation
    {
        /// <summary>
        /// A <see cref="IValidationResult"/>
        /// </summary>
        IValidationResult ValidationResult { get; }

        /// <summary>
        /// True if an entity is valid
        /// </summary>
        bool IsValid { get; }
    }
}