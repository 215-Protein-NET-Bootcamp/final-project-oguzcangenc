using AutoMapper;
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
        public virtual Task<IDataResult<TMainDto>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IDataResult<List<TMainDto>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual Task<IResult> Create(TMainDto input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IResult> Update(TUpdateDto input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IResult> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
