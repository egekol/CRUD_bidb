using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
//using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
        //-----------
        //Business altında çekeceğin database'i iş kodlarını yazabilmek için kullanabilmen gerek.
        //Bütün database'i new leyerek çekmen çok yanlış (çok büyük olabilir, değişiklikler gösterebilir).
        //IProductDal _productDal = new InMemoryProductDal(); ----- YANLIŞ
        //Bunun için öğrendiğimiz yöntem: INJECTION.
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        //-----------
        
        public List<Product> GetAll()
        {
            //İş kodları... yetkisi var mı(if kodu)? then:
            return _productDal.GetAll();

        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}