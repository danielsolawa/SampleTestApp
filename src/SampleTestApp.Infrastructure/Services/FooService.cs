using System;
using SampleTestApp.Core.Domains;
using SampleTestApp.Core.Repositories;

namespace SampleTestApp.Infrastructure.Services
{
    public class FooService : IFooService
    {

        private readonly IFooRepository _fooRepository;

        public FooService(IFooRepository fooRepository)
        {
            _fooRepository = fooRepository;
        }
        public Foo GetFooById(Guid id)
        {
            return _fooRepository.GetFooById(id);
        }
    }
}