using System;
using MediatR;
using ASHR.Wordpass.InternalApi.Queries;
using ASHR.Wordpass.InternalApi.Data;
using System.Threading.Tasks;
using System.Threading;
using ASHR.Wordpass.Domain.Api.Service;
using System.Collections.Generic;
using AutoMapper;

namespace ASHR.Wordpass.Application.Handles
{
    public class GetAllProjectAccessObjectQueryHandler : IRequestHandler<GetAllProjectAccessObjectQuery, GetAllProjectAccessObjectQueryResult>
    {
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;

        public GetAllProjectAccessObjectQueryHandler(IProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }

        public async Task<GetAllProjectAccessObjectQueryResult> Handle(GetAllProjectAccessObjectQuery request, CancellationToken cancellationToken)
        {
            var result = new List<AccessObjectDTO>();
            var project = await _projectService.FindOneAsync(request.guid);

            foreach (var accessObject in project.AccessObjects)
            {
                result.Add(_mapper.Map<AccessObjectDTO>(accessObject));
            }

            return new GetAllProjectAccessObjectQueryResult
            {
                Data = result
            };
        }
    }

    public class AccessObjectDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
