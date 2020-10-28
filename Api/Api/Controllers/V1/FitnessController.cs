using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Resources;
using AutoMapper;
using Data;
using Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.V1
{
    [Route("v1/fitness")]
    [ApiController]
    public class FitnessController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public FitnessController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
       
        [Route("sliders")]
        [HttpGet]
        public async Task<IActionResult> GetSlider()
        {
            var sliders = await _unitOfWork.Slider.GetAllAsync();
            var sliderResources = _mapper.Map<IEnumerable<Slider>, IEnumerable<SliderResource>>(sliders);
            return Ok(sliderResources);
        }
        [Route("cards")]
        [HttpGet]
        public async Task<IActionResult> GetCard()
        {
            var cards = await _unitOfWork.Cards.GetAllAsync();
            var cardResources = _mapper.Map<IEnumerable<Cards>, IEnumerable<CardsResource>>(cards);
            return Ok(cardResources);
        }
        [Route("teams")]
        [HttpGet]
        public async Task<IActionResult> GetTeam()
        {
            var teams = await _unitOfWork.Team.GetAllAsync();
            var teamResources = _mapper.Map<IEnumerable<Team>, IEnumerable<TeamResource>>(teams);
            return Ok(teamResources);
        }
        [Route("firsts")]
        [HttpGet]
        public async Task<IActionResult> GetFirst()
        {
            var firsts = await _unitOfWork.First.GetAllAsync();
            var firstResources=_mapper.Map<IEnumerable<First>,IEnumerable<FirstResource>>(firsts);
            return Ok(firstResources);
        }
        [Route("pricings")]
        [HttpGet]
        public async Task<IActionResult> GetPricing()
        {
            var pricings = await _unitOfWork.Pricing.GetAllAsync();
            var pricingResources = _mapper.Map<IEnumerable<Pricing>, IEnumerable<PricingResource>>(pricings);
            return Ok(pricingResources);
        }
        [Route("services")]
        [HttpGet]
        public async Task<IActionResult> GetServices()
        {
            var services = await _unitOfWork.Services.GetAllAsync();
            var servicesResources = _mapper.Map<IEnumerable<Services>, IEnumerable<ServicesResource>>(services);
            return Ok(servicesResources);
        }
        [Route("fitness")]
        [HttpGet]
        public async Task<IActionResult> GetFitness()
        {
            var fitness = await _unitOfWork.Fitness.GetAllAsync();
            var fitnessResources = _mapper.Map<IEnumerable<Fitness>, IEnumerable<FitnessResource>>(fitness);
            return Ok(fitnessResources);
        }
        [Route("schedules")]
        [HttpGet]
        public async Task<IActionResult> GetSchedule()
        {
            var schedule = await _unitOfWork.Schedule.GetAllAsync();
            var scheduleResources=_mapper.Map<IEnumerable<Schedule>, IEnumerable<ScheduleResource>>(schedule);
            return Ok(scheduleResources);
        }
    }
}
