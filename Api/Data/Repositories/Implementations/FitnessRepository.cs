using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
    public class FitnessRepository : Repository<Fitness>, IFitnessRepository
    {
        public FitnessRepository (ApplicationDbContext context):base(context){}
    }
}
