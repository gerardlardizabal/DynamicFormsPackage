using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicForms;

namespace Base.Core.App.Views.DynamicFormsComponent
{
    [ViewComponent(Name = "DynamicForm")]
    public class DynamicFormsViewComponent : ViewComponent
    {

        DynamicForms.Objects.Forms forms;
        public DynamicFormsViewComponent(DynamicForms.Interfaces.IFormService formService)
        {
            forms = new DynamicForms.Objects.Forms(formService);
        }

        public async Task<IViewComponentResult> InvokeAsync(Guid formId)
        {
            DynamicForms.Objects.Forms.Form form = forms.GetForm(formId).FirstOrDefault();
            return View("~/Views/DynamicFormsComponent/DynamicFormViewComponent.cshtml",form);
        }
    }
}
