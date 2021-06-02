using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace ASHR.Wordpass.Controller.Api
{
    [ApiController]
    public abstract class ApiWordpassBaseController : ControllerBase, WordpassApi
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}