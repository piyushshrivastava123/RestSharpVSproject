using PiyushFinal.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiyushFinal.Base
{
    public class Settings
    {
        public Uri BaseUrl { get; set; }

        public IRestResponse<GetPlaceResponse> Response { get; set; }

        public IRestRequest Request { get; set; }

        public RestClient Client { get; set; }


    }
}
