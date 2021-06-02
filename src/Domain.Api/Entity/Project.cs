using System;
using System.Collections.Generic;

namespace ASHR.Wordpass.Domain.Api.Entity
{
    public class Project
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<AccessObject> AccessObjects { get; set; }
        

    }
}
