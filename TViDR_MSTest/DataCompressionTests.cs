using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using datacompression;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Reflection;
using imageprocessing;
using System.Linq;

namespace TViDR_MSTest
{
    [TestClass]
    public class AcmDataTransformationTest
    {
        [TestMethod]
        public void TestAcmObject()
        {
            string data = "CCBBBBBAAAA";
            ACM acm = ACM.GetInstance(data);
            Assert.AreEqual(data, acm.Data);
        }
        [TestMethod]
        public void TestAcmDictionary()
        {
            string data = "Kox-n-hoop_";

            ACM acm = ACM.GetInstance(data);

            Dictionary<char, decimal> assertData = new Dictionary<char, decimal>() { { 'o', 0.272727272727272727272727m }, { '-', 0.454545454545454545454545m }, { 'K', 0.545454545454545454545454m }, { 'x', 0.636363636363636363636363m }, { 'n', 0.727272727272727272727272m }, { 'h', 0.818181818181818181818181m }, { 'p', 0.909090909090909090909090m }, { '_', 1m }, };

            List<char> keyList = new List<char>(acm.Dict.Keys);

            foreach (char key in keyList)
            {
                Assert.AreEqual(Decimal.Round(assertData[key], 22), Decimal.Round(acm.Dict[key], 22));
            }
        }
    }
    [TestClass]
    public class MtfDataCompressionTest
    {
        [TestMethod]
        public void TestMtfObject()
        {
            string data = "AABBCCDD";
            MTF mtf = MTF.GetInstance(data);
            Assert.AreEqual(data, mtf.Data);
        }
        [TestMethod]
        public void TestMtfLanguage()
        {
            string data = "AABBCCDD";
            MTF mtf = MTF.GetInstance(data);
            Assert.AreEqual("en_US", mtf.Language);
            mtf.Data = "ААББВВГГ";

            Assert.AreEqual("ru_RU", mtf.Language);
        }
        [TestMethod]
        public void TestMtfCompression()
        {
            string data = "BANANAAA";
            MTF mtf = MTF.GetInstance(data);
            int[] assertData = { 1, 1, 13, 1, 1, 1, 0, 0 };
            mtf.CompressData();
            CollectionAssert.AreEqual(assertData, mtf.CompressedData);
        }
    }
    [TestClass]
    public class BtwDataTransformationTest
    {
        [TestMethod]
        public void TestBtwObject()
        {
            string data = "ABACABA";
            BWT btw = BWT.GetInstance(data);
            Assert.AreEqual(data, btw.Data);
        }
        [TestMethod]
        public void TestBtwTransformation()
        {
            string data = "ABACABA";

            BWT btw = BWT.GetInstance(data);

            btw.TrasformData();

            string assertData = "BCABAAA";

            Assert.AreEqual(assertData, btw.TransformedData);
        }
    }
    [TestClass]
    public class IpmDataProcessingTest
    {
        [TestMethod]
        public void TestIPMEncoding()
        {
            List<QuantityOfPixels> assertData = new List<QuantityOfPixels>();
            QuantityOfPixels series = new QuantityOfPixels();
            series.quantity = 8;
            series.pixel = Color.FromArgb(255,0,0,0);
            assertData.Add(series);
            series.quantity = 8;
            series.pixel = Color.FromArgb(255, 255, 255, 255);
            assertData.Add(series);
            IPM ipm = new IPM("C:\\Users\\derri\\OneDrive\\Documents\\TViDR_Res\\4x4SampleMH.bmp");
            ipm.ZigZag();
            ipm.RLE();
            for (int i = 0; i < assertData.Count(); i++)
            {
                Assert.AreEqual(assertData[i].pixel, ipm.EncodedData[i].pixel);
                Assert.AreEqual(assertData[i].quantity, ipm.EncodedData[i].quantity);
            }
        }
    }
}