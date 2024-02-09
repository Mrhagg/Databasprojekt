using DataLagring.Contexts;
using DataLagring.Entities;

namespace DataLagring.Repositories
{
    internal class CountryRepository : Repo<CountryEntity>
    {
        public CountryRepository(DataContext context) : base(context)
        {
        }
    }



}
