using System;
using System.Collections.Generic;
using SampleTestApp.Core.Domains;

namespace SampleTestApp.Core.Repositories
{
    public interface IFooRepository
    {
        Foo GetFooById(Guid id);

    }
}