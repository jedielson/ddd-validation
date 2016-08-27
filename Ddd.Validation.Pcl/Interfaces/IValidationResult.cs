using System.Collections.Generic;

namespace Ddd.Validation.Interfaces
{
    /// <summary>
    /// It provides a set of methods to build the result of a validation
    /// </summary>
    public interface IValidationResult
    {
        /// <summary>
        /// A collection of <see cref="IValidationError"/>
        /// </summary>
        ICollection<IValidationError> Errors { get; }

        /// <summary>
        /// True if the <see cref="IValidationResult"/> does not contain error
        /// </summary>
        bool IsValid { get; }

        /// <summary>
        /// Add an <see cref="IValidationError"/> to the validation
        /// </summary>
        /// <param name="error">An <see cref="IValidationError"/></param>
        /// <returns>A <see cref="IValidationResult"/></returns>
        IValidationResult Add(IValidationError error);

        /// <summary>
        /// Add an error message to the validation
        /// </summary>
        /// <param name="errorMessage">An error message</param>
        /// <returns>A <see cref="IValidationResult"/></returns>
        IValidationResult Add(string errorMessage);

        /// <summary>
        /// Add a collection of <see cref="IValidationResult"/> to the validation
        /// </summary>
        /// <param name="validationResults">A collection of <see cref="IValidationResult"/></param>
        /// <returns>A <see cref="IValidationResult"/></returns>
        IValidationResult Add(params IValidationResult[] validationResults);

        /// <summary>
        /// Add an <see cref="IValidationError"/> to the validation
        /// </summary>
        /// <param name="error">An <see cref="IValidationError"/></param>
        /// <returns>A <see cref="IValidationResult"/></returns>
        IValidationResult Remove(IValidationError error);
    }
}