using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace TestingExercises
{
    [TestClass]
    public class ExampleTest
    {
        [TestMethod]
        public void WorldIsSane()
        {
            Assert.IsTrue(true);
        }

        public interface Foo
        {
            int Bar();
        }

        private class Baz
        {
            private readonly Foo _foo;

            public Baz(Foo foo)
            {
                _foo = foo;
            }

            public bool Qux()
            {
                return _foo.Bar() == 1337;        
            }
        }

        [TestMethod]
        public void NSubstituteExample()
        {
            var aFoo = Substitute.For<Foo>();
            aFoo.Bar().Returns(1337);

            var aBaz = new Baz(aFoo);

            Assert.IsTrue(aBaz.Qux());
        }
    }
}
