using ExtensionMethodsCollection.Tests.ObjectExtensions.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsCollection.Tests.ObjectExtensions
{
    public class ObjectExtensionsCloneTests : IClassFixture<ObjectExtensionsCloneFixture>
    {
        private readonly ObjectExtensionsCloneFixture _fixture;


        public ObjectExtensionsCloneTests(ObjectExtensionsCloneFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void MustCloneEntity()
        {
            var obj = _fixture.TestObjectA;

            var result = obj.Clone();

            Assert.NotNull(result);
        }

        [Fact]
        public void WhenCloningEntityMustCloneId()
        {
            var obj = _fixture.TestObjectA;

            var result = obj.Clone();

            Assert.True(obj.Id == result.Id);
        }

        [Fact]
        public void WhenCloningEntityMustCloneObjectInstance()
        {
            var obj = _fixture.TestObjectA;

            var result = obj.Clone();

            Assert.NotNull(result.TestObjectB);
        }

        [Fact]
        public void WhenCloningEntityMustCloneObjectListInstance()
        {
            var obj = _fixture.TestObjectA;

            var result = obj.Clone();

            Assert.NotNull(result.TestObjectC);
        }

        [Fact]
        public void WhenCloningEntityMustCloneObjectListItens()
        {
            var obj = _fixture.TestObjectA;

            var result = obj.Clone();

            Assert.NotEmpty(result.TestObjectC);
        }
    }
}
