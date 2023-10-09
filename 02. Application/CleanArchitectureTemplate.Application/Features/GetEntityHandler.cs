using AutoMapper;
using CleanArchitectureTemplate.Application.DataContext;
using CleanArchitectureTemplate.Domain.Entities;
using MediatR;
using SegurosSura.Core.Domain.Interfaces;


namespace CleanArchitectureTemplate.Application.Features
{
    public class GetEntityHandler : IRequestHandler<GetEntityQuery, IEnumerable<GetEntityModel>>
    {
        private readonly IMapper _mapper;
        private readonly ITraceHelper _traceHelper;
        private readonly IUnitOfWork _unitOfWork;

        public GetEntityHandler(IMapper mapper, ITraceHelper traceHelper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _traceHelper = traceHelper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<GetEntityModel>> Handle(GetEntityQuery request, CancellationToken cancellationToken)
        {
            var entity =  await _unitOfWork
                ._Entities
                .GetAllEntityAsync();
            var result = _mapper.Map<IEnumerable<GetEntityModel>>(entity);

            return result.ToList();
        }
    }
}
