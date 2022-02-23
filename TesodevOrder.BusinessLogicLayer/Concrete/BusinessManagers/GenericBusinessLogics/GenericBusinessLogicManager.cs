﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TesodevOrder.CoreLayer.Abstract.IResponses.IResults;
using TesodevOrder.CoreLayer.Concrete.Entities;
using TesodevOrder.InterfaceLayer.Abstract.IGenericService;

namespace TesodevOrder.BusinesLogicLayer.Concrete.BusinessManagers.GenericBusinessLogics
{
    public class GenericBusinessLogicManager<T, TDto> : IGenericService<T, TDto> where T : Entity where TDto : Dto
    {
        public IDataResult<TDto> Add(TDto entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<TDto>> AddAsync(TDto entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public IDataResult<bool> DeleteById(int id, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<bool>> DeleteByIdAsync(int id, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public IDataResult<bool> Delete(TDto entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<bool>> DeleteAsync(TDto entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public IDataResult<TDto> Update(TDto entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<TDto>> UpdateAsync(TDto entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public IDataResult<TDto> Find(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IQueryable<T>> GetIQueryable()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TDto>> GetAll(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
