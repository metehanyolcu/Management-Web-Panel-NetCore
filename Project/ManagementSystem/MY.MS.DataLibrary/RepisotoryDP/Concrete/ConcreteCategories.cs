using MY.MS.DataLibrary.EFCore.Context;
using MY.MS.DataLibrary.RepisotoryDP.Abstract;
using MY.MS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY.MS.DataLibrary.RepisotoryDP.Concrete
{
    public class ConcreteCategories : IBusinessMS<Categories>
    {
        public void Add(Categories t)
        {
            using (var cat = new DataContext())
            {
                cat.Categories.Add(t);
                cat.SaveChanges();
            };
        }

        public Categories GetT()
        {
            using (var cat = new DataContext())
            {
                return cat.Categories.Find(cat);
            };
        }

        public List<Categories> ListAll()
        {
            using (var cat = new DataContext())
            {
                return cat.Categories.ToList();
            };
        }

        public List<Categories> ListByID(int id)
        {
            using (var cat = new DataContext())
            {
               var val = cat.Categories.Find(id);
                return cat.Categories.Where(c => c.CategoryID == id).ToList();
            }
        }

        public void ListByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove(Categories t)
        {
            using (var cat = new DataContext())
            {
                cat.Remove(t);
                cat.SaveChanges();
            }
        }

        public void Update(Categories t)
        {
            using (var cat = new DataContext())
            {
                cat.Entry<Categories>(t).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                cat.Update(t);
                cat.SaveChanges();
            }
        }

        public void UpdateByID(int id)
        {
            using (var cat = new DataContext())
            {
                cat.Entry<Categories>(cat.Categories.Find(id)).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                cat.SaveChanges();
            }
        }
    }
}
