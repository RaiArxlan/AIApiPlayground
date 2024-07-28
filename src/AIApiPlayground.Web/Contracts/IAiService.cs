namespace AIApiPlayground.Web.Contracts
{
    public interface IAiService
    {
        Task<IEnumerable<Attribute>> GetAttributesAsync(string CategoryName);
    }
}
