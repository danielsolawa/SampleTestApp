using System;
using SampleTestApp.Core.Domains;

namespace SampleTestApp.Infrastructure.Services
{
    public interface IFooService
    {
        Foo GetFooById(Guid id);
    }
}