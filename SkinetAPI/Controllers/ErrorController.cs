using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkinetAPI.Errors;

namespace SkinetAPI.Controllers
{
    [Route("errors/{code}")]
    public class ErrorController : BaseApiController
    {
        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}
