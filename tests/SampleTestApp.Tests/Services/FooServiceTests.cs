using System;
using Moq;
using SampleTestApp.Core.Domains;
using SampleTestApp.Core.Repositories;
using SampleTestApp.Infrastructure.Services;
using Xunit;

namespace SampleTestApp.Tests.Services
{
    public class FooServiceTests
    {


        [Fact]
        public void GetFooByIdShouldReturnAValidFooObject()
        {
            var id = Guid.NewGuid();
            var name = "bar";
            var foo = new Foo(id, name);

            var fooRepository = new Mock<IFooRepository>();
            fooRepository.Setup(x => x.GetFooById(It.IsAny<Guid>()))
                        .Returns(foo);

            var fooService = new FooService(fooRepository.Object);


            var fooResult = fooService.GetFooById(id);

            fooRepository.Verify(x => x.GetFooById(It.IsAny<Guid>()), Times.Once);

            Assert.NotNull(foo);
            Assert.Equal(id, foo.Id);
            Assert.Equal(name, foo.Name);

        }
    }
}