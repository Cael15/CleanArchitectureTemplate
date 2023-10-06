using AutoMapper;
using MediatR;
using SegurosSura.Core.Domain.Interfaces;


namespace CleanArchitectureTemplate.Application.Features
{
    public class GetEntityHandler : IRequestHandler<GetEntityQuery, IEnumerable<GetEntityModel>>
    {
        private readonly IMapper _mapper;
        private readonly ITraceHelper _traceHelper;

        public GetEntityHandler(IMapper mapper, ITraceHelper traceHelper)
        {
            _mapper = mapper;
            _traceHelper = traceHelper;
        }

        public Task<IEnumerable<GetEntityModel>> Handle(GetEntityQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
