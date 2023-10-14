using MediatR;

namespace CleanArchitectureTemplate.Application.Features
{
    public class GetEntityQuery : IRequest<IEnumerable<GetEntityModel>>
    {
        public GetEntityQuery(Guid id)
        {
            this.Id = id;
        }

        public Guid Id { get; }
    }
}