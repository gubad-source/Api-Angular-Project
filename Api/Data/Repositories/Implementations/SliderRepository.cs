using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
    public class SliderRepository:Repository<Slider>,ISliderRepository
    {
        public SliderRepository(ApplicationDbContext context) : base(context) { }
    }
}
