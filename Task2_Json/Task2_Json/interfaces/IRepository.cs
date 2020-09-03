using System.Collections.Generic;

namespace Task2_Json.interfaces
{
    interface IRepository<T> where T: class
    {
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        T ShowAll(string path);
    }
}
