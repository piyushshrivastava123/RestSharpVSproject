using PiyushFinal.Model;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiyushFinal.TestData
{
    class AddPlaceTestData
    {
        public GetPlaceRequest addPlacePayload(string name, string phone_number, string address, string language )
        {
            GetPlaceRequest p = new GetPlaceRequest();

			p.accuracy = "60";
			p.address = address;
			p.language = language;
			p.name = name;
			p.phone_number = phone_number;
			p.website = "www.google.com";			
			ArrayList myList = new ArrayList();
			myList.Add("first item");
			myList.Add("second Item");
			p.types = myList;			
			Location l = new Location();
			l.lat = 111.111;
			l.lng = 999.999;
			p.location = l;

			return p;
        }




    }
}
