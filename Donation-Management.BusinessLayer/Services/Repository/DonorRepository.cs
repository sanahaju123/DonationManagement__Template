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
    public class DonorRepository:IDonorRepository
    {
        private readonly NgoDbContext _ngoContext;
        public DonorRepository(NgoDbContext ngoDbContext)
        {
            _ngoContext = ngoDbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donorId"></param>
        /// <returns></returns>
        public async Task<Donor> FindDonorById(long donorId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donor"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<Donor> Register(Donor donor, string password)
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<Donor> UpdateDonor(RegisterDonorViewModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Donor>> ListAllDonors()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngoId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Donor>> GetDonorByNgoId(long ngoId)
        {
            throw new NotImplementedException();

        }
    }
}
    
