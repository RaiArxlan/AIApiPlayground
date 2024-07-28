using AIApiPlayground.Web.Models;

namespace AIApiPlayground.Web.Contracts
{
    public interface IAttributeService
    {
        public Task<IEnumerable<Attribute>> GetAttributesAsync(InputFile InputFile);
        
        public Task<IEnumerable<Attribute>> GetSubCategoryAttributesAsync(InputFile InputFile);
    }
}
