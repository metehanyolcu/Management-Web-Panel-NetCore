using MY.MS.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MY.MS.Entities.Concrete
{
    public class Items : ITable
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int ItemStock { get; set; }
        public int CategoryID { get; set; }
        public List<Categories> Categories { get; set; }


    }
}
