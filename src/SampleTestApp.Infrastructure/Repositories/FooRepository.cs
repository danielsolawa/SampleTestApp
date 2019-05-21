using System;
using System.Collections.Generic;
using System.Linq;
using SampleTestApp.Core.Domains;
using SampleTestApp.Core.Repositories;

namespace SampleTestApp.Infrastructure.Repositories
{
    public class FooRepository : IFooRepository
    {
        private static ISet<Foo> foos = new HashSet<Foo>()
        {
            new Foo("John"),
            new Foo("Hannah")
        };

        public Foo GetFooById(Guid id) => foos.SingleOrDefault(x => x.Id == id);

    }
}