using Donation_Management.BusinessLayer.Interfaces;
using Donation_Management.BusinessLayer.ViewModels;
using Donation_Management.DataLayer;
using Donation_Management.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation_Management.BusinessLayer.Services.Repository
{
    public class NgoRepository : INgoRepository
    {
        private readonly NgoDbContext _ngoContext;
        public NgoRepository(NgoDbContext ngoDbContext)
        {
            _ngoContext = ngoDbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngoId"></param>
        /// <returns></returns>
        public async Task<NgoDetails> FindNgoById(long  ngoId)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngoDetails"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<NgoDetails> Register(NgoDetails ngoDetails, string password)
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<NgoDetails> UpdateNgo(RegisterNgoViewModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<NgoDetails>> ListAllNgos()
        {
            throw new NotImplementedException();
        }
    }
}
