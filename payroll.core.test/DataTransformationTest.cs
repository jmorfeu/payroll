using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace payroll.core.test
{
    [TestClass]
    public class DataTransformationTest
    {
        [TestMethod]
        public void StringTransformation()
        {
            IDataTransformation dataTransformation = new DataTransformation();
            string data = "Astrid=mo10:00-12:00,th12:00-14:00,su20:00-21:00";
            var datatransform=dataTransformation.StringTransformation(data);
            Assert.AreEqual("Astrid", datatransform.Name);
            Assert.IsNotNull(datatransform.Rates);
            Assert.AreEqual(3,datatransform.Rates.Count);


        }
      

    }
}
