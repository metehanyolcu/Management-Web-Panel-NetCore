using MY.MS.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MY.MS.Entities.Concrete
{
    public class Categories : ITable
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
       
        public List<Items> Items { get; set; }
    }
}
