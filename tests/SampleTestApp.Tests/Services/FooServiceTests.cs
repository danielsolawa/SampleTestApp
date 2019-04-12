using System;
using SampleTestApp.Infrastructure.Services;
using Xunit;

namespace SampleTestApp.Tests.Services
{
    public class FooServiceTests
    {
        private readonly IFooService _fooService;

        public FooServiceTests()
        {
            _fooService = new FooService();
        }

        [Fact]
        public void GetFooByIdShouldReturnAValidFooObject()
        {
            var id = Guid.NewGuid();
            var foo = _fooService.GetFooById(id);

            Assert.NotNull(foo);
            Assert.Equal(id, foo.Id);
        }
    }
}