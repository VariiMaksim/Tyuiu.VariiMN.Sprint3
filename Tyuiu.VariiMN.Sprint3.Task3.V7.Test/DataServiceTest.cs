using Tyuiu.VariiMN.Sprint3.Task3.V7.Lib;

namespace Tyuiu.VariiMN.Sprint3.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "gft hggt ntg";
            char iz = 'g';
            char zam = '4';
            string res = ds.ReplaceCharOnNum(value, iz, zam);

            string wait = "4ft h44t nt4";
            Assert.AreEqual(wait, res);


        }
    }
}
