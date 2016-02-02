using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OracleCodeFirst.Models;
using OracleCodeFirst;
using System.Linq;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }


        [TestMethod]
        public void TestOracle()
        {
            OracleContext context = new OracleContext();
            var data = context.Test.FirstOrDefault();
            
        }
    }
}
