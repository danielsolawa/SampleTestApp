using System;
using SampleTestApp.Core.Domains;

namespace SampleTestApp.Infrastructure.Services
{
    public class FooService : IFooService
    {
        public Foo GetFooById(Guid id)
        {
            return new Foo(id, "Bar");
        }
    }
}