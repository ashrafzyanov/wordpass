using MediatR;
using ASHR.Wordpass.InternalApi.Data;

namespace ASHR.Wordpass.InternalApi.Queries
{
    /// <summary>
    /// Get all projects
    /// </summary>
    public class GetAllProjectQuery : IRequest<GetAllProjectQueryResult>
    {
    }
}

