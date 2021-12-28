using MY.MS.BusinessLayer.Repisotory.Abstract;
using MY.MS.DataLibrary.RepisotoryDP.Concrete;
using MY.MS.Entities.Concrete;
using System.Collections.Generic;

namespace MY.MS.BusinessLayer.Repisotory.Concrete
{
    public class C_Users : IBusinessC<Users>
    {
        private readonly ConcreteUsers usersdb;
        public C_Users()
        {
            usersdb = new ConcreteUsers();
        }
        public void Add(Users t)
        {
            usersdb.Add(t);
        }

        public Users GetT(int id)
        {
            return  usersdb.GetT(id);
        }

        public List<Users> ListAll()
        {
            return usersdb.ListAll();
        }

        public List<Users> ListByID(int id)
        {
            return usersdb.ListByID(id);
        }

        public void ListByName(string name)
        {
           usersdb.ListByName(name);
        }

        public void Remove(Users t)
        {
            usersdb.Remove(t);
        }

        public void Update(Users t)
        {
            usersdb.Update(t);
        }

        public void UpdateByID(int id)
        {
            usersdb.UpdateByID(id);
        }
    }
}
