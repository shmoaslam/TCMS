using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCMS.Models
{
    public class InstituteModel : BaseModel 
    {
        public InstituteModel()
        {
            Address = new AddressModel();
        }

        public int Id { get; set; }
        public int Name { get; set; }
        public AddressModel Address { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string AltContactNo { get; set; }

    }
}