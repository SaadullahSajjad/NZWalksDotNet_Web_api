using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

//instead of writing if and else in each controller methods again n again
//we make this cutom validation check cass that will do for us

namespace NZWalks.API.CustomActionFilter
{
    public class ValidateModelAttributes: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if(context.ModelState.IsValid == false) {

                context.Result = new BadRequestResult();
            }
        }
    }
}
