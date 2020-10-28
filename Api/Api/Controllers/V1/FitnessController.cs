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
    }
}
