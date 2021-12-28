using MY.MS.BusinessLayer.Repisotory.Abstract;
using MY.MS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY.MS.BusinessLayer.Repisotory.Concrete
{
    public class C_Categories : IBusinessC<Categories>
    {
        private readonly MY.MS.DataLibrary.RepisotoryDP.Concrete.ConcreteCategories catdb;
        public C_Categories()
        {
            catdb = new DataLibrary.RepisotoryDP.Concrete.ConcreteCategories();
        }


        public void Add(Categories t)
        {
            catdb.Add(t);
        }

        public Categories GetT(int id)
        {
            return catdb.GetT(id);
        }

        public List<Categories> ListAll()
        {
            return catdb.ListAll();
        }

        public List<Categories> ListByID(int id)
        {
            return catdb.ListByID(id);
        }

        public void ListByName(string name)
        {
            catdb.ListByName(name);
        }

        public void Remove(Categories t)
        {
            catdb.Remove(t);
        }

        public void Update(Categories t)
        {
            catdb.Update(t);   
        }

        public void UpdateByID(int id)
        {
            catdb.UpdateByID(id);
        }
    }
}
