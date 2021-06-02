using System;
using MediatR;
using ASHR.Wordpass.InternalApi.Data;

namespace ASHR.Wordpass.InternalApi.Queries 
{
    /// <summary>
    /// Get all available project access object
    /// </summary>
    public class GetAllProjectAccessObjectQuery : IRequest<GetAllProjectAccessObjectQueryResult>
    {
        private readonly Guid _guid;

        public GetAllProjectAccessObjectQuery(Guid guid)
        {
            _guid = guid;
        }

        public Guid guid { get => _guid; }
    }
}
