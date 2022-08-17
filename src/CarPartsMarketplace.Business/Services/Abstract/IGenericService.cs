using CarPartsMarketplace.Core.Utilities.Results;

namespace CarPartsMarketplace.Business.Services.Abstract
{
    public interface IGenericService<TMainDto, TCreateDto, TUpdateDto>
    {
        Task<IDataResult<TMainDto>> Get(int id);
        Task<IDataResult<List<TMainDto>>> GetAll();
        Task<IResult> Create(TMainDto input);
        Task<IResult> Update(TUpdateDto input);
        Task<IResult> Delete(int id);
    }
}
