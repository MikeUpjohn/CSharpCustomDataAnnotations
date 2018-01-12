using System.ComponentModel.DataAnnotations;

namespace custom_attributes.Data.Attributes
{
    public class MaximumFieldLengthAttribute : ValidationAttribute
    {
        public int MaxLength { get; set; }

        public MaximumFieldLengthAttribute(int maxNum)
        {
            MaxLength = maxNum;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var number = (int?)value;

            return number > this.MaxLength ? new ValidationResult(this.ErrorMessage) : ValidationResult.Success;
        }
    }
}