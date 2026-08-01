using System.ComponentModel.DataAnnotations;

namespace Implementing_Custom_Validation_E_F.Models
{
    public class MinAgeAttribute : ValidationAttribute
    {
        private readonly int _minAge;

        public MinAgeAttribute(int minAge)
        {
            _minAge = minAge;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is int age && age < _minAge)
            {
                return new ValidationResult($"Age must be at least {_minAge}.");
            }
            return ValidationResult.Success;
        }
    }
}
