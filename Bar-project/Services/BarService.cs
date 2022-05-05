using System;
using System.Threading.Tasks;

namespace Bar_project.Services
{
    public class BarService
    {
        public BarService()
        {
        }

        public async Task<string> GetBarAsync()
        {
            return "Barfromservice";
        }
    }
}
