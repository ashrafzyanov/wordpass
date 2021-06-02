using System;
using System.Collections.Generic;
using System.Text;

namespace ASHR.Wordpass.Domain.Api.Entity
{
    public class AccessObject
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
