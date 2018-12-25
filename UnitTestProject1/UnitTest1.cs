using System;
using Currency_Converter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCurrencyReturnMethod()
        {

            decimal givenCurrency = 20, productPrice = 10;
            decimal price = (givenCurrency - productPrice);
            int exceptedTenPound = 1;
            CurChange change = new CurChange(price);
            int actualReturnFromMethod = change.TenPound;
            Assert.AreEqual(exceptedTenPound, actualReturnFromMethod);
        }
    }
}
