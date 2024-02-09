using DataLagring.Contexts;
using DataLagring.Entities;

namespace DataLagring.Repositories
{
    internal class PlayerRepository : Repo<PlayerEntity>
    {
        public PlayerRepository(DataContext context) : base(context)
        {
        }
    }



}
