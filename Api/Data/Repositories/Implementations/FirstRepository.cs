using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
    public class FirstRepository:Repository<First>,IFirstRepository
    {
        public FirstRepository(ApplicationDbContext context) : base(context) { }
    }
}
