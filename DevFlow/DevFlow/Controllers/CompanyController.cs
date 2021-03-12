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

namespace DevFlow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICompanyService _companyService;

        public CompanyController(IMapper mapper, ICompanyService companyService)
        {
            this._mapper = mapper;
            this._companyService = companyService;
        }
        [HttpPost("Create-Company")]
        public ActionResult CreateCompany(CreateCompanyDTO createCompany)
        {
            var createCompanyMapped = _mapper.Map<Company>(createCompany);
            _companyService.CreateCompany(createCompanyMapped);
            return Ok();
        }
        [HttpGet("Get-Company-By-Id")]
        public ActionResult<ResponseCompanyDTO> GetCompany(int idCompany)
        {
            try
            {
                var company = _companyService.GetCompany(idCompany);
                var responseCompanyDTOMapped = _mapper.Map<ResponseCompanyDTO>(company);
                return Ok(responseCompanyDTOMapped);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
        [HttpGet("Get-All-Companies")]
        public ActionResult<List<ResponseCompanyWithJobOffersDTO>> GetAllCompanies()
        {
            try
            {
                var companies = _companyService.GetAllCompanies();
                var listOfResponseCompanyWithJobOffersDTO = _mapper.Map<List<ResponseCompanyWithJobOffersDTO>>(companies);
                return Ok(listOfResponseCompanyWithJobOffersDTO);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
        [HttpDelete("Delete-Company")]
        public ActionResult DeleteCompany(int idCompanyToDelete)
        {
            try
            {
                _companyService.DeleteCompanyById(idCompanyToDelete);
                return Ok();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
        [HttpPut("Update-Company")]
        public ActionResult UpdateCompany(int idCompanyToUpdate, CreateCompanyDTO newCompanyValues)
        {
            try
            {
                var companyMappedNewValues = _mapper.Map<Company>(newCompanyValues);
                _companyService.UpdateCompanyById(idCompanyToUpdate, companyMappedNewValues);
                return Ok();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
