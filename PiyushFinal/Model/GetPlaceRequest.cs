using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiyushFinal.Model
{
    class GetPlaceRequest
    {

        public Location location { get; set; }
        public string accuracy { get; set; }
        public string name { get; set; }

        public string phone_number { get; set; }

        public string address { get; set; }

        public ArrayList types { get; set; }

        public string website { get; set; }

        public string language { get; set; }


    }
}

