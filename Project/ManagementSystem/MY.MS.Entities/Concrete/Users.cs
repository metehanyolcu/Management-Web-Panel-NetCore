using MY.MS.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MY.MS.Entities.Concrete
{
    public class Users : ITable
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Age { get; set; }
    }
}
