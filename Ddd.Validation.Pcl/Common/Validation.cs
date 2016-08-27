using System;
using System.Collections.Generic;
using Ddd.Validation.Interfaces;

namespace Ddd.Validation.Common
{
    
    /// <inheritdoc/>
    public class Validation<TEntity> : IValidation<TEntity>
       where TEntity : class
    {
        private readonly Dictionary<string, IValidationRule<TEntity>> _validationsRules;

        /// <summary>
        /// Initializes a new instance of <see cref="Validation{TEntity}"/>
        /// </summary>
        public Validation()
        {
            _validationsRules = new Dictionary<string, IValidationRule<TEntity>>();
        }

        /// <inheritdoc/>
        protected virtual void AddRule(IValidationRule<TEntity> validationRule)
        {
            var ruleName = validationRule.GetType() + Guid.NewGuid().ToString("D");
            _validationsRules.Add(ruleName, validationRule);
        }

        /// <inheritdoc/>
        protected virtual void RemoveRule(string ruleName)
        {
            _validationsRules.Remove(ruleName);
        }

        /// <inheritdoc/>
        public virtual IValidationResult Valid(TEntity entity)
        {
            var result = new ValidationResult();
            foreach (var key in _validationsRules.Keys)
            {
                var rule = _validationsRules[key];
                if (!rule.Valid(entity))
                    result.Add(new ValidationError(rule.ErrorMessage));
            }
            return result;
        }
    }
}