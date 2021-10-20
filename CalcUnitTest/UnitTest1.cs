using Microsoft.VisualStudio.TestTools.UnitTesting;
using AttributeTestApp;

namespace CalcUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod("더하기 테스트")]
        public void TestMethod1()
        {
            Myclass myClass = new Myclass();
            int a =3, b = 5;
            var result = myClass.Plus(a, b);

            Assert.AreEqual(8, result);  // 테스트 결과
        }
      
        [TestMethod] // 이걸 넣어야 테스트가 나옴
        public void DivideTest()
        {
            Myclass myClass = new Myclass();
            int a = 10, b = 3;
            
            var result = myClass.Divide(a, b);
            var expected = 3;
            Assert.AreEqual(expected, result);
        }
    }
}
