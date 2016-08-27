using System.Text.RegularExpressions;
using Ddd.Validation.Interfaces;

namespace Ddd.Validation.Extensions
{
    /// <summary>
    /// Provê um conjunto de extensões à <see cref="IValidationResult"/> de forma a executar validações rápidas e com
    /// escrita fluente.
    /// </summary>
    public static partial class AssertionConcern
    {
        /// <summary>
        /// Executa o método <see cref="object.Equals(object)"/> entre o <see cref="object1"/> e <see cref="object2"/>
        /// </summary>
        /// <param name="validationResult">Um <see cref="IValidationResult"/></param>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <param name="errorMessage">A mensagem de erro a ser retornada em <see cref="validationResult"/></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentEquals(this IValidationResult validationResult, object object1, object object2, string errorMessage)
        {
            if (!object1.Equals(object2))
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        /// <summary>
        /// Executa o método <see cref="object.Equals(object)"/> entre o <see cref="object1"/> e <see cref="object2"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentNotEquals(this IValidationResult validationResult, object object1, object object2, string errorMessage)
        {
            if (object1.Equals(object2))
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        /// <summary>
        /// Verifica se o uma string possui tamanho menor que <see cref="maximum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="stringValue"></param>
        /// <param name="maximum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentLength(this IValidationResult validationResult, string stringValue, int maximum, string errorMessage)
        {
            int length = stringValue.Trim().Length;
            if (length > maximum)
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="stringValue"/> possui tamanho entre <see cref="minimum"/> e <see cref="maximum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="stringValue"></param>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentLength(this IValidationResult validationResult, string stringValue, int minimum, int maximum, string errorMessage)
        {
            if (string.IsNullOrEmpty(stringValue))
                stringValue = string.Empty;

            int length = stringValue.Trim().Length;
            if (length < minimum || length > maximum)
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        /// <summary>
        /// Dado que <see cref="pattern"/> é um pattern Regex, verifica se <see cref="stringValue"/> é compatível com este pattern
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="pattern"></param>
        /// <param name="stringValue"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentMatches(this IValidationResult validationResult, string pattern, string stringValue, string errorMessage)
        {
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(stringValue))
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        /// <summary>
        /// Verifica se uma string não é vazia
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="stringValue"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentNotEmpty(this IValidationResult validationResult, string stringValue, string errorMessage)
        {
            if (string.IsNullOrEmpty(stringValue?.Trim()))
            {
                validationResult.Add(errorMessage);
            }
            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="object1"/> não é nulo
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="object1"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentNotNull(this IValidationResult validationResult, object object1, string errorMessage)
        {
            if (object1 == null)
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        public static IValidationResult AssertIsEmail(this IValidationResult validationResult, string email, string message)
        {
            if (
                !Regex.IsMatch(email,
                    @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                    RegexOptions.IgnoreCase))
                validationResult.Add(message);

            return validationResult;
        }
    }
}
