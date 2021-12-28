using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY.MS.BusinessLayer.Repisotory.Abstract
{
    public interface IBusinessC<T> where T : class
    {
        List<T> ListAll();
        List<T> ListByID(int id);
        void ListByName(string name);
        void Add(T t);
        void Remove(T t);
        void Update(T t);
        void UpdateByID(int id);
        T GetT(int id);
    }
}
