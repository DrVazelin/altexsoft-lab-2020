using System.Collections.Generic;

namespace Task2_Json.interfaces
{
    interface IRepository<T> where T: class
    {
        void Create(T item);
        T Read(string path);
        void Update(string path,T item);
        void Delete(int id);
    }
}
