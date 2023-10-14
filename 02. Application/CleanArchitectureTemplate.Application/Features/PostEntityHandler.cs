using AutoMapper;
using CleanArchitectureTemplate.Application.DataContext;
using CleanArchitectureTemplate.Domain.Entities;
using MediatR;
using SegurosSura.Core.Domain.Interfaces;

namespace CleanArchitectureTemplate.Application.Features
{
    public class PostEntityHandler : IRequestHandler<PostEntityCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly ITraceHelper _traceHelper;
        private readonly IUnitOfWork _unitOfWork;

        public PostEntityHandler(IMapper mapper, ITraceHelper traceHelper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _traceHelper = traceHelper;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(PostEntityCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var entity = _mapper.Map<Entity>(request);
                await _unitOfWork._Entities.InsertEntityAsync(entity);

                return true;
            }
            catch (Exception ex)
            {

                _traceHelper.TraceInfo($"Error en la creación de la entidad - Exception: {ex.Message} - InnerException: {ex.InnerException}");
                return false; 
            }
        }
    }
}
