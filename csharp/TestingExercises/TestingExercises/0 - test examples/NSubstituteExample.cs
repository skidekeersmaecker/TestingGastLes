using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace TestingExercises.test
{
    public class NSubstituteExample
    {
        public interface IFoo
        {
            int Bar();
        }

        private class Baz
        {
            private readonly IFoo _foo;

            public Baz(IFoo foo)
            {
                _foo = foo;
            }

            public bool Qux()
            {
                return _foo.Bar() == 1337;
            }
        }

        [TestMethod]
        public void Example()
        {
            var aFoo = Substitute.For<IFoo>();
            aFoo.Bar().Returns(1337);

            var aBaz = new Baz(aFoo);

            Assert.IsTrue(aBaz.Qux());
        }
    }
}