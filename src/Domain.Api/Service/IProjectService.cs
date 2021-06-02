using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ASHR.Wordpass.Domain.Api.Entity;

namespace ASHR.Wordpass.Domain.Api.Service
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> FindAllAsync();

        Task<Project> FindOneAsync(Guid id);
    }
}
