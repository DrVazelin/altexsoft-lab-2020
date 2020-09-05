using System.Collections.Generic;

namespace Task2_Json.interfaces
{
    interface IRepository<T> where T: class
    {
        void Create(string path, string fileName, T recipes);
        T Read(string path);
        void Update(string path,T item);
        void Delete(string path,int id);
    }
}
