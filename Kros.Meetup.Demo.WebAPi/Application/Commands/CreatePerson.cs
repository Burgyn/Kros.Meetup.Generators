using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MMLib.MediatR.Generators.Controllers;

namespace Kros.Meetup.Demo.WebAPi.Application.Commands
{
    public class CreatePerson
    {
        /// <summary>
        /// Testing comment.
        /// </summary>
        [HttpPost(Controller = "People")]
        public record Command(string FirstName, string LastName) : IRequest<int>
        {
            [Microsoft.AspNetCore.Authorization.AllowAnonymous]
            [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
            [Microsoft.AspNetCore.Mvc.ProducesResponseType(Microsoft.AspNetCore.Http.StatusCodes.Status201Created, Type = typeof(int))]
            private void RequestMethodDefinition()
            {
                throw new NotImplementedException();
            }
        }

        public class Handler : IRequestHandler<Command, int>
        {
            public Task<int> Handle(Command request, CancellationToken cancellationToken)
                => Task.FromResult(new Random().Next());
        }
    }
}
