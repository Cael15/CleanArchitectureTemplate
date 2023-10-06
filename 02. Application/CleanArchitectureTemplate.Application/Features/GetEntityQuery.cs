using MediatR;

namespace CleanArchitectureTemplate.Application.Features
{
    public class GetEntityQuery : IRequest<IEnumerable<GetEntityModel>>
    {
        public GetEntityQuery(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; }
    }
}