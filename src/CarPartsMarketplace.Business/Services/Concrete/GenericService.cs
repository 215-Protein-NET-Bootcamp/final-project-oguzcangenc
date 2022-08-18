﻿using AutoMapper;
using CarPartsMarketplace.Business.Constant;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Core.Data;
using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;

namespace CarPartsMarketplace.Business.Services.Concrete
{
    public abstract class GenericService<TMainDto, TCreateDto, TUpdateDto, TEntity> : IGenericService<TMainDto, TCreateDto, TUpdateDto> where TEntity : BaseEntity, IEntity, new()
    {
        private readonly IEfGenericRepository<TEntity> _baseRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        protected GenericService(IEfGenericRepository<TEntity> baseRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public virtual async Task<IDataResult<TMainDto>> Get(int id)
        {
            var tempEntity = await _baseRepository.GetAsync(p => p.Id == id);
            var result = _mapper.Map<TEntity, TMainDto>(tempEntity);

            return new SuccessDataResult<TMainDto>(result, Messages.RECORD_LISTED);
        }

        public virtual async Task<IDataResult<IEnumerable<TMainDto>>> GetAll()
        {
            // Get list record from DB
            var tempEntity = await _baseRepository.GetAllAsync();
            // Mapping Entity to Resource
            var result = _mapper.Map<IEnumerable<TEntity>, IEnumerable<TMainDto>>(tempEntity);

            return new SuccessDataResult<IEnumerable<TMainDto>>(result, Messages.RECORD_LISTED);
        }

        public virtual async Task<IResult> Create(TCreateDto createResource)
        {
            try
            {
                var tempEntity = _mapper.Map<TCreateDto, TEntity>(createResource);
                await _baseRepository.AddAsync(tempEntity);
                await _unitOfWork.CompleteAsync();

                return new SuccessDataResult<TCreateDto>(_mapper.Map<TEntity, TCreateDto>(tempEntity), Messages.RECORD_ADDED);
            }
            catch (Exception ex)
            {
                throw new MessageResultException(Messages.ADD_ERROR, ex);
            }
        }

        public virtual async Task<IResult> Update(int id, TUpdateDto updateResource)
        {
            try
            {
                var tempEntity = await _baseRepository.GetByIdAsync(id);
                if (tempEntity is null)
                    return new ErrorDataResult<TUpdateDto>(Messages.ID_NOT_EXISTENT);

                tempEntity = _mapper.Map(updateResource, tempEntity);
                _baseRepository.Update(tempEntity);
                await _unitOfWork.CompleteAsync();

                var resource = _mapper.Map<TEntity, TUpdateDto>(tempEntity);

                return new SuccessDataResult<TUpdateDto>(resource, Messages.RECORD_UPDATED);
            }
            catch (Exception ex)
            {
                throw new MessageResultException(Messages.UPDATE_ERROR, ex);
            }
        }

        public virtual async Task<IResult> Delete(int id)
        {
            try
            {
                // Validate Id is existent
                var tempEntity = await _baseRepository.GetByIdAsync(id);
                if (tempEntity is null)
                    return new ErrorResult(Messages.ID_NOT_EXISTENT);

                _baseRepository.Delete(tempEntity);
                await _unitOfWork.CompleteAsync();

                return new SuccessResult(Messages.RECORD_DELETED);
            }
            catch (Exception ex)
            {
                throw new MessageResultException(Messages.DELETE_ERROR, ex);
            }
        }
    }
}
