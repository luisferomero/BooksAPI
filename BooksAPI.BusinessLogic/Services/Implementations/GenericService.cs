using AutoMapper;
using BooksAPI.BusinessLogic.DTOs;
using BooksAPI.BusinessLogic.Responses;
using BooksAPI.BusinessLogic.Services.Interfaces;
using BooksAPI.Persistence.Repositories;
using BooksAPI.Persistence.UnitOfWork;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksAPI.BusinessLogic.Services.Implementations
{
    public class GenericService<TEntity, TDto> : BaseService, IGenericService<TEntity, TDto> where TEntity : class where TDto : IBaseDto
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<TEntity> _repository;
        private readonly IMapper _mapper;
        private readonly IValidator _validator;


        public GenericService(IUnitOfWork uow, IMapper mapper, IGenericRepository<TEntity> repository, AbstractValidator<TDto> validator)
        {
            _uow = uow;
            _repository = repository;
            _mapper = mapper;
            _validator = validator;
        }

        public virtual async Task<ResultResponse> CreateAsync(TDto dto)
        {
            var validation = Validate(_validator, dto);
            if (!validation.IsValid)
                return Error(validation.Errors);

            var entity = _mapper.Map<TEntity>(dto);
            _repository.Add(entity);
            await _uow.SaveChangesAsync();
            return Success();
        }

        public async Task<ResultResponse> Update(TDto dto)
        {
            var validation = Validate(_validator, dto);
            if (!validation.IsValid)
                return Error(validation.Errors);

            var entity = _mapper.Map<TEntity>(dto);
            _repository.Update(entity);
            await _uow.SaveChangesAsync();
            return Success();
        }

        public ResultResponse Delete(int Id)
        {
            var entity = _repository.GetById(Id);
            _repository.Remove(entity);
            _uow.SaveChanges();
            return Success();
        }

        public virtual ResultResponse GetAll()
        {
            var all = _repository.GetAll();
            var mapped = _mapper.Map<List<TDto>>(all);
            return Success(mapped);
        }

        public virtual ResultResponse GetById(int Id)
        {
            var entity = _repository.GetById(Id);
            var mapped = _mapper.Map<TDto>(entity);
            return Success(mapped);
        }
    }
}
