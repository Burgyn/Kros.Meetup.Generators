using MediatR;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using MMLib.MediatR.Generators.Controllers;

namespace Kros.Meetup.Demo.WebAPi.Application.Commands
{
    public class UpdatePerson
    {
        /// <summary>
        /// Command for update person.
        /// </summary>
        [HttpPut("{id:int}", Controller = "People")]
        [AdditionalParameters("id")]
        public record Command() : IRequest<Unit>
        {
            [JsonIgnore]
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            public Task<Unit> Handle(Command request, CancellationToken cancellationToken)
                => Unit.Task;
        }
    }
}
