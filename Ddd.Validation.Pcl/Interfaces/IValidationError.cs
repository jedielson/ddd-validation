namespace Ddd.Validation.Interfaces
{
    /// <summary>
    /// It provides a set of methods to build a validation error
    /// </summary>
    public interface IValidationError
    {
        /// <summary>
        /// The message of the error
        /// </summary>
        string Message { get; set; }
    }
}