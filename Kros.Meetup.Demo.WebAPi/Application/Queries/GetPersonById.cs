using AutoBogus;
using Kros.Extensions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using MMLib.MediatR.Generators.Controllers;

namespace Kros.Meetup.Demo.WebAPi.Application.Queries
{
    public class GetPersonById
    {
        [HttpGet("{id}", Controller = "People", Name = "GetById")]
        public record Query(int Id) : IRequest<Response>;

        public class Handler : IRequestHandler<Query, Response>
        {
            public Task<Response> Handle(Query request, CancellationToken cancellationToken)
                => AutoFaker.Generate<Response>().AsTaskSingleValue();
        }

        public record Response(int Id, string FirstName, string LastName);
    }
}
