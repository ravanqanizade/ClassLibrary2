﻿using ClassLibrary2;

namespace ClassLibrary1.DAL.Repositories.Abstract;

    public interface IRepository<T> where T : BaseEntity, new()
    {
        public void Add(T entity);
        public void Update(int Id);
        public void Delete(int Id);

        public T GetById(int Id);
        public ICollection<T> GetAll();
        public void SaveChanges();

    }
