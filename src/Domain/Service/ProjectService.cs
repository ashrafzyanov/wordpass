using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ASHR.Wordpass.Domain.Api.Entity;
using ASHR.Wordpass.Domain.Api.Service;

namespace ASHR.Wordpass.Domain.Service
{
    public class ProjectService : IProjectService
    {
        private readonly List<Project> data;

        public ProjectService()
        {
            var project1 = new Project
            {
                Id = Guid.NewGuid(),
                Name = "Project1"
            };

            project1.AccessObjects = new List<AccessObject> {
                new AccessObject
                {
                    Id = Guid.NewGuid(),
                    Name = "AccessObject1 Project1"
                },
                new AccessObject
                {
                    Id = Guid.NewGuid(),
                    Name = "AccessObject2 Project1"
                },
                new AccessObject
                {
                    Id = Guid.NewGuid(),
                    Name = "AccessObject3 Project1"
                },
            };

            var project2 = new Project
            {
                Id = Guid.NewGuid(),
                Name = "Project2"
            };
            project2.AccessObjects = new List<AccessObject> {
                new AccessObject
                {
                    Id = Guid.NewGuid(),
                    Name = "AccessObject1 Project2"
                },
                new AccessObject
                {
                    Id = Guid.NewGuid(),
                    Name = "AccessObject2 Project2"
                },
                new AccessObject
                {
                    Id = Guid.NewGuid(),
                    Name = "AccessObject3 Project2"
                },
            };


            data = new List<Project> { project1, project2 };
        }

        public async Task<IEnumerable<Project>> FindAllAsync()
        {
            return data;
        }

        public async Task<Project> FindOneAsync(Guid id)
        {
            if (id.Equals("a7649626-3d1b-4041-9052-d90d35567ef1"))
            {
                return data[0];
            }
            return data[1];
        }
    }
}
