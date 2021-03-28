using CSharpPredictor;
using CSharpPredictorML.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ModelInput MI = new ModelInput();
            MI.Company = "vaz";
            MI.Model = 2107;
            MI.EnginePower = 73;
            MI.EngineVolume = 1.6F;
            MI.Link = "https://auto.ru/cars/used/sale/vaz/2107/1102859563-9739e148/";
            MI.Mileage = 120000;
            MI.Transmission = false;
            MI.Year = 2010;
            string json = JsonConvert.SerializeObject(MI);
            var str = json.ToString();
            var sum = Predictor.PredictOnePrice(str);
            Console.WriteLine($"\n\nPredicted Price: {sum}\n\n");
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            ModelInput MI = new ModelInput();
            MI.Company = "vaz";
            MI.Model = 2107;
            MI.EnginePower = 73;
            MI.EngineVolume = 1.6F;
            MI.Link = "https://auto.ru/cars/used/sale/vaz/2107/1102859563-9739e148/";
            MI.Mileage = 90000;
            MI.Transmission = false;
            MI.Year = 2010;
            MI.Price = 100000;

            ModelInput M1 = new ModelInput();
            M1.Company = "vaz";
            M1.Model = 2107;
            M1.EnginePower = 73;
            M1.EngineVolume = 1.6F;
            M1.Link = "https://auto.ru/cars/used/sale/vaz/2107/1102859563-9739e148/";
            M1.Mileage = 130000;
            M1.Transmission = false;
            M1.Year = 2006;
            M1.Price = 100010;

            ModelInput M2 = new ModelInput();
            M2.Company = "vaz";
            M2.Model = 2107;
            M2.EnginePower = 73;
            M2.EngineVolume = 1.6F;
            MI.Link = "https://auto.ru/cars/used/sale/vaz/2107/1102859563-9739e148/";
            M2.Mileage = 10000;
            M2.Transmission = false;
            M2.Year = 2020;
            M2.Price = 100020;


            List<ModelInput> v2 = new List<ModelInput> ();
            v2.Add(MI);
            v2.Add(M1);
            v2.Add(M2);

            string json = JsonConvert.SerializeObject(v2);
            var sum = Predictor.GetBestDeals(json);
            Assert.IsTrue(true);
        }
    }
}
