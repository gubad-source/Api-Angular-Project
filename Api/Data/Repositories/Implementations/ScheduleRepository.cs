using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
    public class ScheduleRepository:Repository<Schedule>,IScheduleRepository
    {
        public ScheduleRepository(ApplicationDbContext context) : base(context) { }
    }
}
