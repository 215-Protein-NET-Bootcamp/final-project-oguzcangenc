using CarPartsMarketplace.Core.Utilities.Results;

namespace CarPartsMarketplace.Business.Services.Abstract
{
    public interface IGenericService<TMainDto, TCreateDto, TUpdateDto>
    {
        Task<IDataResult<TMainDto>> Get(int id);
        Task<IDataResult<IEnumerable<TMainDto>>> GetAll();
        Task<IResult> Create(TCreateDto createResource);
        Task<IResult> Update(int id, TUpdateDto updateResource);
        Task<IResult> Delete(int id);
    }
}
