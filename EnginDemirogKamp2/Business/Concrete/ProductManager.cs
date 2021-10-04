using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
//using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;

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
        public IDataResult<List<Product>> GetAll()
        {
            //İş kodları... yetkisi var mı(if kodu)? then:
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Product>>( _productDal.GetAll(),Messages.ProductsListed);
        }
        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id)) ;
        }
        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }
        public IDataResult<List<ProductDetailDto>> GetProductDetailDtos()
        {
            if (DateTime.Now.Hour==15)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.getProductDetailDtos());
        }
        public IResult Add(Product product)
        {
            if (product.ProductName.Length <2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }
        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }
    } 
}