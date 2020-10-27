using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
    public class CardsRepository:Repository<Cards>,ICardsRepository
    {
        public CardsRepository(ApplicationDbContext context) : base(context) { }
    }
}
