using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base.Core.App.Views.DynamicFormsComponent.Components.DynamicFormFieldComponent
{
    [ViewComponent(Name ="DynamicFormField")]
    public class DynamicFormFieldComponent : ViewComponent
    {
        public DynamicFormFieldComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync(DynamicForms.Objects.FormFields.FormField field)
        {
            return View("~/Views/DynamicFormsComponent/Components/DynamicFormFieldComponent/DynamicFormFieldComponent.cshtml",field);
        }
    }
}
