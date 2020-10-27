using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
    public class PricingRepository:Repository<Pricing>,IPricingRepository
    {
        public PricingRepository(ApplicationDbContext context) : base(context) { }
    }
}
