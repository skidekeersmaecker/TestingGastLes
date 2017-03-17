using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace TestingExercises
{
    [TestClass]
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
        public void stub_example()
        {
            var aFoo = Substitute.For<IFoo>(); //A fake IFoo object
            aFoo.Bar().Returns(1337); //Arrange: dear aFoo, whenever your Bar() gets called, always return 1337

            var aBaz = new Baz(aFoo);

            Assert.IsTrue(aBaz.Qux());
        }

        [TestMethod]
        public void mock_example()
        {
            var aFoo = Substitute.For<IFoo>(); //A fake IFoo object
            var aBaz = new Baz(aFoo);

            aBaz.Qux();

            aFoo.Received().Bar(); //Assert: dear aFoo, did you receive the message Bar()?
        }
    }
}