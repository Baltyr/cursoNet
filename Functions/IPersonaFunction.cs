using cursodotnet.Models;

namespace cursodotnet.Functions
{
    public interface IPersonaFunction
    {
        Task<List<EntityApi>> GetApis();
    }
}