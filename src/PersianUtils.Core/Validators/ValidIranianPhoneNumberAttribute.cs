using System;
using System.ComponentModel.DataAnnotations;

namespace PersianUtils.Core
{
    /// <summary>
    /// Determines whether the specified value of the object is a valid IranianPhoneNumber.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Parameter)]
    public sealed class ValidIranianPhoneNumberAttribute : ValidationAttribute
    {
        /// <summary>
        /// Determines whether the specified value of the object is valid.
        /// </summary>
        public override bool IsValid(object? value)
        {
            if (value is null)
            {
                return true; // returning false, makes this field required.
            }

            var valStr = value.ToString();
            if (string.IsNullOrWhiteSpace(valStr))
            {
                return true; // returning false, makes this field required.
            }

            return valStr.IsValidIranianPhoneNumber();
        }

        /// <summary>
        /// Determines whether the specified value of the object is valid.
        /// </summary>
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (IsValid(value))
            {
                return null;
            }

            if (validationContext == null)
            {
                throw new ArgumentNullException(nameof(validationContext));
            }

            return string.IsNullOrWhiteSpace(validationContext.MemberName)
                ? new ValidationResult(ErrorMessage)
                : new ValidationResult(ErrorMessage, new[] { validationContext.MemberName });
        }
    }
}