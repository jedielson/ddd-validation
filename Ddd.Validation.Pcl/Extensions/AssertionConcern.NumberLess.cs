using Ddd.Validation.Interfaces;

namespace Ddd.Validation.Extensions
{
    public static partial class AssertionConcern
    {
        #region Less
        /// <summary>
        /// Verifica se <see cref="value"/> é menor que <see cref="minimum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentIsLessThan(this IValidationResult validationResult, double value, double minimum, string errorMessage)
        {
            if (value >= minimum)
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="value"/> é menor que <see cref="minimum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentIsLessThan(this IValidationResult validationResult, float value, float minimum, string errorMessage)
        {
            if (value >= minimum)
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="value"/> é menor que <see cref="minimum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentIsLessThan(this IValidationResult validationResult, int value, int minimum, string errorMessage)
        {
            if (value >= minimum)
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="value"/> é menor que <see cref="minimum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentIsLessThan(this IValidationResult validationResult, long value, long minimum, string errorMessage)
        {
            if (value >= minimum)
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="value"/> é menor que <see cref="minimum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentIsLessThan(this IValidationResult validationResult, decimal value, decimal minimum, string errorMessage)
        {
            if (value >= minimum)
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }
        #endregion

        #region GreaterOrEqual
        /// <summary>
        /// Verifica se <see cref="value"/> é menor ou igual que <see cref="minimum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentIsLessOrEqualThan(this IValidationResult validationResult, double value, double minimum, string errorMessage)
        {
            if (value > minimum)
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="value"/> é menor ou igual que <see cref="minimum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentIsLessOrEqualThan(this IValidationResult validationResult, float value, float minimum, string errorMessage)
        {
            if (value > minimum)
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="value"/> é menor ou igual que <see cref="minimum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentIsLessOrEqualThan(this IValidationResult validationResult, int value, int minimum, string errorMessage)
        {
            if (value > minimum)
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="value"/> é menor ou igual que <see cref="minimum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentIsLessOrEqualThan(this IValidationResult validationResult, long value, long minimum, string errorMessage)
        {
            if (value > minimum)
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }

        /// <summary>
        /// Verifica se <see cref="value"/> é menor ou igual que <see cref="minimum"/>
        /// </summary>
        /// <param name="validationResult"></param>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static IValidationResult AssertArgumentIsLessOrEqualThan(this IValidationResult validationResult, decimal value, decimal minimum, string errorMessage)
        {
            if (value > minimum)
            {
                validationResult.Add(errorMessage);
            }

            return validationResult;
        }
        #endregion
    }
}
