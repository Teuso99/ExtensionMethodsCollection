using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsCollection.Tests.ObjectExtensions.Fixtures
{
    public class ObjectExtensionsCloneFixture
    {
        public TestClassA TestObjectA => new TestClassA()
        {
            Id = 1,
            TestObjectBId = 1,
            TestObjectB = new TestClassB() { Id = 1, Name = "aaa" },
            TestObjectC = new List<TestClassC>() { new TestClassC() { Id = 1, TestObjectAId = 1 } }
        };

        public class TestClassA
        {
            public long Id { get; set; }

            public long TestObjectBId { get; set; }
            public TestClassB? TestObjectB { get; set; }

            public List<TestClassC>? TestObjectC { get; set; }
        }

        public class TestClassB
        {
            public long Id { get; set; }
            public string? Name { get; set; }
        }

        public class TestClassC
        {
            public long Id { get; set; }

            public long TestObjectAId { get; set; }
            public TestClassA? TestObjectA { get; set; }
        }
    }
}
