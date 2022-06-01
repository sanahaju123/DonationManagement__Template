using Donation_Management.BusinessLayer.ViewModels;
using Donation_Management.DataLayer;
using Donation_Management.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation_Management.BusinessLayer.Services.Repository
{
    public class DonationRepository : IDonationRepository
    {
        private readonly NgoDbContext _ngoContext;
        public DonationRepository(NgoDbContext ngoDbContext)
        {
            _ngoContext = ngoDbContext;
        }

        /// <summary>
        /// Return Donation by donation Id
        /// </summary>
        /// <param name="donationId"></param>
        /// <returns></returns>
        public async Task<Donation> FindDonationById(long donationId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donation"></param>
        /// <returns></returns>
        public async Task<Donation> Register(Donation donation)
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<Donation> UpdateDonation(RegisterDonationViewModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Donation>> ListAllDonation()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngoId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Donation>> GetDonationByNgoId(long ngoId)
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donorId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Donation>> GetDonationForDonor(long donorId)
        {
            throw new NotImplementedException();
        }
    }
}
