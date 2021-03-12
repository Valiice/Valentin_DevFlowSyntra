using AutoMapper;
using DevFlow.Services.Interfaces;
using DevFlow.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFlow.DTO.CompanyDTO;
using DevFlow.DTO.JobOfferDTO;

namespace DevFlow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobOfferController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IJobOfferService _jobOfferService;

        public JobOfferController(IMapper mapper, IJobOfferService jobOfferService)
        {
            this._mapper = mapper;
            this._jobOfferService = jobOfferService;
        }
        [HttpPost("Create-JobOffer")]
        public ActionResult CreateJobOffer(CreateJobOfferDTO createJobOffer)
        {
            var jobOfferMapped = _mapper.Map<JobOffer>(createJobOffer);
            _jobOfferService.CreateJobOffer(jobOfferMapped);
            return Ok();
        }
        [HttpGet("Get-JobOffer")]
        public ActionResult<ResponseJobOfferWithCompanyDTO> GetJobOffer(int idJobOffer)
        {
            try
            {
                var jobOffer = _jobOfferService.GetJobOffer(idJobOffer);
                var jobOfferWithCompanyDTO = _mapper.Map<ResponseJobOfferWithCompanyDTO>(jobOffer);
                return Ok(jobOfferWithCompanyDTO);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
        [HttpGet("Get-All-JobOffers")]
        public ActionResult<List<ResponseJobOfferWithCompanyDTO>> GetAllJobOffers()
        {
            try
            {
                var jobOffers = _jobOfferService.GetAllJobOffers();
                var jobOfferWithCompanyDTO = _mapper.Map<List<ResponseJobOfferWithCompanyDTO>>(jobOffers);
                return Ok(jobOfferWithCompanyDTO);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
        [HttpDelete("Delete-JobOffer")]
        public ActionResult DeleteJobOffer(int idJobOfferToDelete)
        {
            try
            {
                _jobOfferService.DeleteJobOfferById(idJobOfferToDelete);
                return Ok();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        } 
        [HttpPut("Update-JobOffer")]
        public ActionResult UpdateJobOffers(int idJobOfferToUpdate, CreateJobOfferDTO jobOfferValuesUpdated)
        {
            try
            {
                var jobOfferMapped = _mapper.Map<JobOffer>(jobOfferValuesUpdated);
                _jobOfferService.UpdateJobOfferById(idJobOfferToUpdate, jobOfferMapped);
                return Ok();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
        //TODO NOT FINISHED
        [HttpGet("Last-3-Posted-JobOffers")]
        public ActionResult<List<ResponseJobOfferWithCompanyDTO>> GetLast3Offers()
        {
            try
            {
                return Ok();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
