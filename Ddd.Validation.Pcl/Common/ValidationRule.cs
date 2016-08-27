using Ddd.Specification.Interfaces;
using Ddd.Validation.Interfaces;

namespace Ddd.Validation.Common
{
    /// <inheritdoc/>
    public class ValidationRule<TEntity> : IValidationRule<TEntity>
    {
        private readonly ISpecification<TEntity> _specificationRule;

        /// <summary>
        /// Initializes a new instance of <see cref="ValidationRule{TEntity}"/>
        /// </summary>
        /// <param name="specificationRule">An <see cref="ISpecification{TEntity}"/></param>
        /// <param name="errorMessage">An error message</param>
        public ValidationRule(ISpecification<TEntity> specificationRule, string errorMessage)
        {
            _specificationRule = specificationRule;
            ErrorMessage = errorMessage;
        }

        /// <inheritdoc/>
        public string ErrorMessage { get; }

        /// <inheritdoc/>
        public bool Valid(TEntity entity)
        {
            return _specificationRule.IsSatisfiedBy(entity);
        }
    }
}