using NUnit.Framework;
using Kazaam;

namespace kazaamSmash {
    [TestFixture()]
    public class XNATest {
        [Test()]
        public void XNAGameTest() {
            XNAGame Game = new XNAGame();
            Assert.IsInstanceOf<XNAGame>(Game);
        }
    }
}
