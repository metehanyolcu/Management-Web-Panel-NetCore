using MY.MS.DataLibrary.EFCore.Context;
using MY.MS.DataLibrary.RepisotoryDP.Abstract;
using MY.MS.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace MY.MS.DataLibrary.RepisotoryDP.Concrete
{
    public class ConcreteItems : IBusinessMS<Items>
    {
        public void Add(Items t)
        {
            using (var dbi = new DataContext())
            {
                dbi.Items.Add(t);
                dbi.SaveChanges();
            }
        }

        public Items GetT(int id)
        {
            using (var dbi = new DataContext())
            {
                return dbi.Items.Find(id);
            }
        }

        public List<Items> ListAll()
        {
            using (var dbi = new DataContext())
            {
                return dbi.Items.ToList();
            }
        }

        public List<Items> ListByID(int id)
        {
            using (var dbi = new DataContext())
            {
                return dbi.Items.Where(i => i.ItemID ==  id).ToList();
            }
        }

        public void ListByName(string name)
        {
            using (var dbi = new DataContext())
            {
              
            }
        }

        public void Remove(Items t)
        {
            using (var dbi = new DataContext())
            {
                dbi.Items.Remove(t);
                dbi.SaveChanges();
            }
        }

        public void Update(Items t)
        {
            using (var dbi = new DataContext())
            {
                dbi.Update(t);
                dbi.SaveChanges();
            }
        }

        public void UpdateByID(int id)
        {
            using (var dbi = new DataContext())
            {
                dbi.Entry<Items>(dbi.Items.FirstOrDefault(i => i.ItemID == id)).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dbi.SaveChanges();
            }
        }
    }
}
