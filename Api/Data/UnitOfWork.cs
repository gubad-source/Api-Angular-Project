using Data.Repositories.Implementations;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private CardsRepository _cardsRepository;
        private FirstRepository _firstRepository;
        private FitnessRepository _fitnessRepository;
        private PricingRepository _pricingRepository;
        private ScheduleRepository _scheduleRepository;
        private ServicesRepository _servicesRepository;
        private SliderRepository _sliderRepository;
        private TeamRepository _teamRepository;
        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
        }
        public ICardsRepository Cards => _cardsRepository ??= new CardsRepository(_context);
        public IFirstRepository First => _firstRepository ??= new FirstRepository(_context);
        public IFitnessRepository Fitness => _fitnessRepository ??= new FitnessRepository(_context);
        public IPricingRepository Pricing => _pricingRepository ??= new PricingRepository(_context);
        public IScheduleRepository Schedule => _scheduleRepository ??= new ScheduleRepository(_context);
        public IServicesRepository Services => _servicesRepository ??= new ServicesRepository(_context);
        public ISliderRepository Slider => _sliderRepository ??= new SliderRepository(_context);
        public ITeamRepository Team => _teamRepository ??= new TeamRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
