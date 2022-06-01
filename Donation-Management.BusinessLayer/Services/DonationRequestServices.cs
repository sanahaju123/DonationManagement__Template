using Donation_Management.BusinessLayer.Interfaces;
using Donation_Management.BusinessLayer.Services.Repository;
using Donation_Management.BusinessLayer.ViewModels;
using Donation_Management.DataLayer;
using Donation_Management.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation_Management.BusinessLayer.Services
{
    public class DonationRequestServices : IDonationRequestServices
    {
        private readonly IDonationRequestRepository _donationRequestRepository;
        private readonly NgoDbContext _ngoContext;

        public DonationRequestServices(IDonationRequestRepository donationRequestRepository, NgoDbContext ngoDbContext)
        {
            _donationRequestRepository = donationRequestRepository;
            _ngoContext = ngoDbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donationRequestId"></param>
        /// <returns></returns>
        public async Task<DonationRequest> FindDonationRequestById(long donationRequestId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donationRequestDetails"></param>
        /// <returns></returns>
        public async Task<DonationRequest> Register(DonationRequest donationRequestDetails)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<DonationRequest> UpdateDonationRequest(RegisterDonationRequestViewModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<DonationRequest>> ListAllDonationRequest()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngoId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<DonationRequest>> GetDonationRequestByNgoId(long ngoId)
        {

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donorId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<DonationRequest>> GetDonationRequestForDonor(long donorId)
        {
            throw new NotImplementedException();
        }
    }
}

