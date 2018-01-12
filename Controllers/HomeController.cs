using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using custom_attributes.Models;

namespace custom_attributes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MyModel model = new MyModel();
            model.MyNumber = 120;
            model.SecondNumber = 150;

            List<ValidationResult> result = new List<ValidationResult>();
            bool validated = Validator.TryValidateObject(model, new ValidationContext(model), result, true);

            int a = 1;

            return null;
        }
    }
}