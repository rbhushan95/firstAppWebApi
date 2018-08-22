using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Address
    {
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string ZipCode { get; set; }
        public string LandMark { get; set; }
        public string FullAddress { get; set; }
    }
}
