﻿namespace DemoAPI_Docker.Datas
{
    public interface IRepository<T> where T : class
    {
        public T Add(T entity);
        public ICollection<T> GetAll();
        public T GetById(int id);
        public T Update(int id, T entity);
        public bool Delete(int id);

    }
}
