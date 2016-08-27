using Ddd.Validation.Interfaces;

namespace Ddd.Validation.Extensions
{
    public static partial class AssertionConcern
    {
        /// <summary>
        /// Verifica se <see cref="value"/> está entre <see cref="minimum"/> e <see cref="maximum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentRange(this IValidationResult validationResult, double value, double minimum, double maximum, string errorMessage)
        {
            if (value < minimum || value > maximum)
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="value"/> está entre <see cref="minimum"/> e <see cref="maximum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentRange(this IValidationResult validationResult, float value, float minimum, float maximum, string errorMessage)
        {
            if (value < minimum || value > maximum)
            {
                validationResult.Add(errorMessage);
            }
            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="value"/> está entre <see cref="minimum"/> e <see cref="maximum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentRange(this IValidationResult validationResult, int value, int minimum, int maximum, string errorMessage)
        {
            if (value < minimum || value > maximum)
            {
                validationResult.Add(errorMessage);
            }
            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="value"/> está entre <see cref="minimum"/> e <see cref="maximum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentRange(this IValidationResult validationResult, long value, long minimum, long maximum, string errorMessage)
        {
            if (value < minimum || value > maximum)
            {
                validationResult.Add(errorMessage);
            }
            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="value"/> está entre <see cref="minimum"/> e <see cref="maximum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentRange(this IValidationResult validationResult, decimal value, decimal minimum, decimal maximum, string errorMessage)
        {
            if (value < minimum || value > maximum)
            {
                validationResult.Add(errorMessage);
            }
            return validationResult;
        }
    }
}
