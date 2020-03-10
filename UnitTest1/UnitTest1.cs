using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using obg_opg_1;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void ForfatterTest()
            {
                Bog bog = new Bog();
                bog.Forfatter = "x";
            }
            [TestMethod]
                [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void SidetalTest()
            {
                Bog bog = new Bog();
                bog.Sidetal = 1001;
            }
            [TestMethod]
                [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void IsbnTest()
            {
                Bog bog = new Bog();
                bog.Isbn13 = "fdfdfdfdfdffdf";
            }
        }
    }
        
