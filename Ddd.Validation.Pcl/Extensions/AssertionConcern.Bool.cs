using Ddd.Validation.Interfaces;

namespace Ddd.Validation.Extensions
{
    public static partial class AssertionConcern
    {
        /// <summary>
        /// Verifica se <see cref="boolValue"/> é falso
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="boolValue"></param>
        /// <param name="errorMessage">A mensagem de erro à ser retornada em caso de erro.</param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentFalse(this IValidationResult validationResult, bool boolValue, string errorMessage)
        {
            if (boolValue)
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="boolValue"/> é verdadeiro
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="boolValue"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentTrue(this IValidationResult validationResult, bool boolValue, string errorMessage)
        {
            if (!boolValue)
            {
                validationResult.Add(errorMessage);
            }
            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="boolValue"/> é falso
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="boolValue"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertStateFalse(this IValidationResult validationResult, bool boolValue, string errorMessage)
        {
            if (boolValue)
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="boolValue"/> é verdadeiro
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="boolValue"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertStateTrue(this IValidationResult validationResult, bool boolValue, string errorMessage)
        {
            if (!boolValue)
            {
                validationResult.Add(errorMessage);
            }
            return validationResult;
        }
    }
}
