using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer;
using DataModel;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UltimateContext ctx1 = new UltimateContext();

            HtmlData data = new HtmlData();
            data.Data = "<div>asdd asdsadas</div>";
            ctx1.HtmlDatas.Add(data);
            ctx1.SaveChanges();
            Assert.IsNotNull(data.Id);
        }
    }
}
