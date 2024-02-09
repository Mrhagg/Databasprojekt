using DataLagring.Contexts;
using DataLagring.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataLagring.Repositories
{
    internal class TeamRepository : Repo<TeamEntity>
    {
        private readonly DataContext _context;
        public TeamRepository(DataContext context) : base(context)
        {
           _context = context;
        }

        public override TeamEntity Get(Expression<Func<TeamEntity, bool>> expression)
        {
            var entity = _context.Teams
         .Include(i => i.Player)
         .Include(i => i.Coach)
         .Include(i => i.Stadium)
         .Include(i => i.Country)
         .FirstOrDefault(expression);

            return entity!;
        }

        public override IEnumerable<TeamEntity> GetAll()
        {
            return _context.Teams
         .Include(i => i.Player)
         .Include(i => i.Coach)
         .Include(i => i.Stadium)
         .Include(i => i.Country)
         .ToList();
        }
    }
}
