using cursodotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace cursodotnet.Functions
{
    public class PersonaFunction : IPersonaFunction
    {
        private readonly InsuranceCommonContext insuranceCommonContext;

        public PersonaFunction(InsuranceCommonContext insuranceCommonContext)
        {
            this.insuranceCommonContext = insuranceCommonContext;
        }

        public async Task<List<EntityApi>> GetApis()
        {
            return await insuranceCommonContext.Api.ToListAsync();
        }
    }
}