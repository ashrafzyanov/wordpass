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
    public class GetAllProjectQueryHandler : IRequestHandler<GetAllProjectQuery, GetAllProjectQueryResult>
    {
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;

        public GetAllProjectQueryHandler(IProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }

        public async Task<GetAllProjectQueryResult> Handle(GetAllProjectQuery request, CancellationToken cancellationToken)
        {
            var results = new List<ProjectDTO>();
            var projects = await _projectService.FindAllAsync();
            foreach (var project in projects)
            {
                results.Add(_mapper.Map<ProjectDTO>(project));
            }
            return new GetAllProjectQueryResult
            {
                Data = results
            };
        }
    }

    public class ProjectDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
