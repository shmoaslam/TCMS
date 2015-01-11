using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCMS.Models
{
    public class CityModel : BaseModel
    {
        public CityModel()
        {
            State = new StateModel();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public StateModel State { get; set; }
    }
}