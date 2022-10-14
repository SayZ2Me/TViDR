using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using datacompression;

namespace TViDR_MSTest
{
    [TestClass]
    public class DataCompressionTest
    {
        [TestMethod]
        public void TestMtfObject()
        {
            string data = "AABBCCDD";
            MTF mtf = new MTF(data);
            Assert.AreEqual(mtf.Data, data);
        }
        [TestMethod]
        public void TestMtfConstructorAlphabet()
        {
            string data = "AABBCCDD";
            char[] assertData = { 'A', 'B', 'C', 'D' };

            MTF mtf = new MTF(data);

            CollectionAssert.AreEquivalent(mtf.Alphabet, assertData);
        }
        [TestMethod]
        public void TestMtfSetDataAlphabet()
        {
            string data = "AABBCCDD";
            char[] assertData = { 'A', 'B', 'C', 'D' };

            MTF mtf = new MTF();
            mtf.Data = data;

            CollectionAssert.AreEquivalent(mtf.Alphabet, assertData);
        }
    }
}