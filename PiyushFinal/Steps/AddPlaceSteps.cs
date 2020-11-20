using Newtonsoft.Json;
using NUnit.Framework;
using PiyushFinal.Base;
using PiyushFinal.Model;
using PiyushFinal.TestData;
using RestSharp;
using System;
using System.Collections;
using System.IO;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PiyushFinal.Steps
{
    [Binding]
    class AddPlaceSteps
    {
        private Settings _settings;
        AddPlaceTestData testdata = new AddPlaceTestData();

        public AddPlaceSteps(Settings settings) => _settings = settings;

        [Given(@"Add Place payload with body")]
        public void GivenAddPlacePayloadWithBody(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _settings.Request = new RestRequest("/maps/api/place/add/json", Method.POST);
            _settings.Request.RequestFormat = DataFormat.Json;
            _settings.Request.AddQueryParameter("key", "qaclick123");

            _settings.Client = new RestClient("https://rahulshettyacademy.com");

            var jsonObject =  testdata.addPlacePayload(data.name.ToString(), data.phone_number.ToString(), data.address.ToString(), data.language.ToString());
            _settings.Request.AddJsonBody(jsonObject);
           
           // var file = @"TestData\AddPlaceData.json";
           // var jsonData = JsonConvert.DeserializeObject<GetPlaceRequest>(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, file)).ToString());

        }

        [When(@"Perform POST operation for ""(.*)""")]
        public void WhenPerformPOSTOperationFor(string resource)
        {
           
          //  _settings.Request.AddJsonBody(jsonData);           

            _settings.Response = _settings.Client.Execute<GetPlaceResponse>(_settings.Request);
        }

        [Then(@"The API Call got success with status code (.*)")]
        public void ThenTheAPICallGotSuccessWithStatusCode(string code)
        {

            Assert.That(_settings.Response.StatusCode.ToString, Is.EqualTo(code), "Status code is incorrect");
        }

        [Then(@"""(.*)"" in response is ""(.*)""")]
        public void ThenInResponseIs(string key, string value)
        {
            Assert.That(_settings.Response.Data.scope, Is.EqualTo(value), key + "is not correct");
        }

    }
}
