using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCMS.Models
{
    /// <summary>
    /// Student Model
    /// </summary>
    public class StudentModel : BaseModel
    {
        public StudentModel()
        {
            Address = new AddressModel();
            Institute = new InstituteModel();
            Course = new CourseModel();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Genders Gender { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public AddressModel Address { get; set; }
        public string Email { get; set; }
        public string MobileContactNo { get; set; }
        public string HomeContactNo { get; set; }
        public InstituteModel Institute { get; set; }
        public Streams Stream { get; set; }
        public CourseModel Course { get; set; }
    }
}