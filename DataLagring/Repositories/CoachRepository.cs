using DataLagring.Contexts;
using DataLagring.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLagring.Repositories
{
    internal class CoachRepository : Repo<CoachEntity>
    {
        public CoachRepository(DataContext context) : base(context)
        {
        }
    }
}
