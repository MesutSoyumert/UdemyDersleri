using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [CacheAspect(duration: 19)]
        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(filter : p => p.ProductId == productId));
        }


        [CacheAspect(duration: 19)]
        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
        }

        [CacheAspect(duration:19)]
        public IDataResult<List<Product>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(filter: p => p.CategoryId == categoryId).ToList());
        }

        // Cross Cutting Concerns Örnekleri : Validation, Cache, Logging,
        // Performance Management, Authorization, Transation Management
        // Aspect Oriented Programming - AOP

        [ValidationAspect(typeof(ProductValidator), Priority = 1)]
        [CacheRemoveAspect(pattern:"IProductService.Get")]
        [CacheRemoveAspect(pattern: "ICategoryService.Get")]
        public IResult Add(Product product)
        {
            //business rules burada control edilir
            // validation bu seviyede yapılır
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        [ValidationAspect(typeof(ProductValidator), Priority = 1)]
        [CacheRemoveAspect(pattern: "IProductService.Get")]
        [CacheRemoveAspect(pattern: "ICategoryService.Get")]
        public IResult Update(Product product)
        {
            //business rules burada control edilir
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);

        }

        [CacheRemoveAspect(pattern: "IProductService.Get")]
        [CacheRemoveAspect(pattern: "ICategoryService.Get")]
        public IResult Delete(Product product)
        {
            //business rules burada control edilir
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        [TransactionScopeAspect]
        [CacheRemoveAspect(pattern: "IProductService.Get")]
        [CacheRemoveAspect(pattern: "ICategoryService.Get")]
        public IResult TransactionalOperation(Product product)
        {
            _productDal.Update( product);
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductUpdated); 
        }
    }
}
