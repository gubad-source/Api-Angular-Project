using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IUnitOfWork
    {
        ICardsRepository Cards { get; }
        IFirstRepository First { get; }
        IFitnessRepository Fitness { get; }
        IPricingRepository Pricing { get; }
        IScheduleRepository Schedule { get; }
        IServicesRepository Services { get; }
        ISliderRepository Slider { get; }
        ITeamRepository Team { get; }
        Task<int> CommitAsync();
    }
}
