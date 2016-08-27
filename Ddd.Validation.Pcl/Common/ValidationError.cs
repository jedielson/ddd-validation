using Ddd.Validation.Interfaces;

namespace Ddd.Validation.Common
{
    /// <inheritdoc/>
    public class ValidationError : IValidationError
    {
        /// <inheritdoc/>
        public string Message { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="ValidationError"/>
        /// </summary>
        /// <param name="message">An error message</param>
        public ValidationError(string message)
        {
            Message = message;
        }
    }
}