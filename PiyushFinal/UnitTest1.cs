
using NUnit.Framework;
using PiyushFinal.Model;
using RestSharp;
using System;
using System.Collections;

namespace PiyushFinal
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var name = "PiyushFinal";

            Assert.That(name, Is.EqualTo("PiyushFinal"), "name is not correct");

        }



        [Test]
        public void PostWithTypeClassBodyGenericExecuteMethod()

        {
            var client = new RestClient("https://rahulshettyacademy.com/maps/api/place/add/json");

            //  var request = new RestRequest("place_id/{placeid}", Method.GET);
            var request = new RestRequest(Method.POST);
            request.AddQueryParameter("key", "qaclick123");
            request.RequestFormat = DataFormat.Json;
            Location loc = new Location();
            loc.lat = 1.11;
            loc.lng = 2.33;
            ArrayList myList = new ArrayList();
            myList.Add("aaa");
            myList.Add("bbb");

            request.AddBody(new GetPlaceRequest() { accuracy = "68", address = "gggg", language = "fff", location = loc, types = myList, name = "jhddhd", phone_number = "888e8hjjj", website = "jhdjd" });
            var response = client.Execute<GetPlaceResponse>(request);

            Assert.That(response.Data.scope, Is.EqualTo("APP"), "scope is not Correct");

        }
    }
}
