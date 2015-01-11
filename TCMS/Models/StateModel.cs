using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCMS.Models
{
    public class StateModel : BaseModel
    {
        public StateModel()
        {
            Country = new CountryModel();
            Cities = new List<CityModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public CountryModel Country { get; set; }
        public List<CityModel> Cities { get; set; }
    }
}
