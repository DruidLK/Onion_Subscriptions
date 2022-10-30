using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Subscriptions.Applications.UsersApplications.Commands;
using Subscriptions.Contract.UsersDataTransferObjects.Commands;

namespace Subscriptions.API.Controllers.V1
{
    [ApiController]
    [Route(template: "Api/[Controller]")]
    public sealed class UsersController : ControllerBase
    {
        private readonly IUserApplication userApplication;

        public UsersController(IUserApplication userApplication) =>
            this.userApplication = userApplication;

        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] UserRequest userRequest)
        {
            try
            {
                    await this.userApplication
                        .RegisterUser(
                            userRequest.firstName,
                            userRequest.lastName,
                            userRequest.email
                            );

                return Ok(); // should return 201 or use put for add and modify at same time
            }
            catch(Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }


    }
    
}
