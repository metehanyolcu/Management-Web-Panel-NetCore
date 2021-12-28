using MY.MS.BusinessLayer.Repisotory.Abstract;
using MY.MS.DataLibrary.RepisotoryDP.Concrete;
using MY.MS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY.MS.BusinessLayer.Repisotory.Concrete
{
    public class C_Items : IBusinessC<Items>
    {
        private readonly ConcreteItems itemsdb;
        public C_Items()
        {
          itemsdb = new ConcreteItems();
        }
        public void Add(Items t)
        {
           itemsdb.Add(t);
        }

        public Items GetT(int id)
        {
            return itemsdb.GetT(id);
        }

        public List<Items> ListAll()
        {
            return itemsdb.ListAll();
        }

        public List<Items> ListByID(int id)
        {
            return itemsdb.ListByID(id);
        }

        public void ListByName(string name)
        {
            itemsdb.ListByName(name);
        }

        public void Remove(Items t)
        {
            itemsdb.Remove(t);
        }

        public void Update(Items t)
        {
            itemsdb.Update(t);
        }

        public void UpdateByID(int id)
        {
           itemsdb.UpdateByID(id);
        }
    }
}
