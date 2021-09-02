using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;


namespace Core.DataAccess
{
    //Generic constraint
    //Class - reference type
    //IEntity - Interface'i kullanan IEntity ya da IEntity'i implemente eden bir nesne olabilir.
    //new() - new'lenebilir olmalı (IEntity newlenemez, soyut nesneleri kullanmayacağız).
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        T Get(Expression<Func<T,bool>>filter);
        void Add(T product);
        void Update(T product);
        void Delete(T product);
        //List<T> GetAllByCategory(int categoryId);
        //YAZMAK YERİNE
        //Delegation:
        List<T> GetAll(Expression<Func<T,bool>>filter =null);
        //ss
    }
}