using Donation_Management.BusinessLayer.Interfaces;
using Donation_Management.BusinessLayer.ViewModels;
using Donation_Management.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Donation_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorController : ControllerBase
    {
        private readonly IDonorServices _donorServices;
        private readonly IDonationServices _donationServices;
        public DonorController(IDonorServices donorServices, IDonationServices donationServices)
        {
            _donorServices = donorServices;
            _donationServices = donationServices;
        }

        #region DonorRegion
        /// <summary>
        /// Register a new Donor 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("donors/register-donors")]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([FromBody] RegisterDonorViewModel model)
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// Update a existing Donor
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("donors/update-donor")]
        public async Task<IActionResult> UpdateDonor([FromBody] RegisterDonorViewModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete a existing Donor
        /// </summary>
        /// <param name="DonorId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("donors/delete-donor/{DonorId}")]
        public async Task<IActionResult> DeletDonor(long DonorId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Donor by Id
        /// </summary>
        /// <param name="DonorId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("donors/get/{DonorId}")]
        public async Task<IActionResult> GetDonorById(long DonorId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get List of all Donors
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("donors/all")]
        public async Task<IEnumerable<Donor>> ListAllDonors()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get All Donors by NGO Id
        /// </summary>
        /// <param name="ngoId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("donors/get-by-ngo/{ngoId}")]
        public async Task<IEnumerable<Donor>> ListDonorsByNgoId(long ngoId)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region DonationRegion

        /// <summary>
        /// Register a new Donation
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("donation/create-donation")]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromBody] RegisterDonationViewModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update a Existing Donation
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("donation/update-donation")]
        public async Task<IActionResult> UpdateDonation([FromBody] RegisterDonationViewModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete a existing donation
        /// </summary>
        /// <param name="DonationId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("donation/delete-donation/{DonationId}")]
        public async Task<IActionResult> DeletDonation(long DonationId)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Get donation by Id
        /// </summary>
        /// <param name="DonationId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("donation/get/{DonationId}")]
        public async Task<IActionResult> GetDonationById(long DonationId)
        {
            throw new NotImplementedException();
        }
        

        /// <summary>
        /// List All Donations
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("donation/all")]
        public async Task<IEnumerable<Donation>> ListAllDonations()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get donor by donor Id
        /// </summary>
        /// <param name="donorId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("donation/get-by-donor/{donorId}")]
        public async Task<IEnumerable<Donation>> GetDonationByDonorId(long donorId)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get donation by Ngo Id
        /// </summary>
        /// <param name="ngoId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("donation/get-by-ngo/{ngoId}")]
        public async Task<IEnumerable<Donation>> GetDonationByNgoId(long ngoId)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

