using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCMS.Models
{
    public class UserModel : BaseModel
    {
        public UserModel()
        {
            Student = new StudentModel();
        }
        public int Id { get; set; }
        public string ClassCode { get; set; }
        public int TypeId { get; set; }
        public StudentModel Student { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int LoginCounter { get; set; }
        public DateTime LastLogin { get; set; }
    }
}