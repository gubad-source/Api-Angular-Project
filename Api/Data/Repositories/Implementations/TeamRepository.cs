using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
    public class TeamRepository:Repository<Team>,ITeamRepository
    {
        public TeamRepository(ApplicationDbContext context) : base(context) { }
    }
}
