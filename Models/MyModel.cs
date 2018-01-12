using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using custom_attributes.Data.Attributes;

namespace custom_attributes.Models
{
    public class MyModel
    {
        [MaximumFieldLength(20, ErrorMessage = "Too long value.")]
        public int MyNumber { get; set; }

        [MaximumFieldLength(150, ErrorMessage = "Too long again...")]
        public int SecondNumber { get; set; }
    }
}