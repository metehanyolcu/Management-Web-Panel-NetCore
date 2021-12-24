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
    public class ConcreteUsers : IBusinessMS<Users>
    {
        public void Add(Users t)
        {
            using (var user =   new DataContext())
            {
                user.Add(t);
                user.SaveChanges();
            }
        }

        public Users GetT(int id)
        {
            using (var user = new DataContext())
            {
               
                return user.Users.FirstOrDefault(u => u.UserID == id);
            }
        }

        public List<Users> ListAll()
        {
            using (var db = new DataContext())
            {
                return db.Users.ToList();
            }
        }

        public List<Users> ListByID(int id)
        {
            using (var db = new DataContext())
            {
                return db.Users.Where(u => u.UserID == id).ToList();
            }
        }

        public void ListByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove(Users t)
        {
            using (var db = new DataContext())
            {
                db.Users.Remove(t);
                db.SaveChanges();
            }
        }


        public void Update(Users t)
        {
            using (var db = new DataContext())
            {
                db.Users.Update(t);
                db.SaveChanges();
            }
        }

        public void UpdateByID(int id)
        {
            using (var db = new DataContext())
            {
                db.Entry<Users>(db.Users.Find(id)).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
