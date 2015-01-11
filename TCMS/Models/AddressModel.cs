using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCMS.Models
{
    public class AddressModel : BaseModel   
    {
        public AddressModel()
        {
            City = new CityModel();
        }
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Zipcode { get; set; }
        public CityModel City { get; set; }
    }
}