using System.Collections.Generic;

namespace MY.MS.DataLibrary.RepisotoryDP.Abstract
{
    public interface IBusinessMS<T> where T : class
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
