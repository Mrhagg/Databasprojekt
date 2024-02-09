using DataLagring.Contexts;
using DataLagring.Entities;

namespace DataLagring.Repositories
{
    internal class StadiumRepository : Repo<StadiumEntity>
    {
        public StadiumRepository(DataContext context) : base(context)
        {
        }
    }



}
