﻿using Donation_Management.BusinessLayer.Interfaces;
using Donation_Management.BusinessLayer.Services;
using Donation_Management.BusinessLayer.Services.Repository;
using Donation_Management.BusinessLayer.ViewModels;
using Donation_Management.DataLayer;
using Donation_Management.Entities;
using Donation_Management.TestCases;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Donation_Management.Tests.TestCases
{
    public class BoundaryTest
    {
        private readonly ITestOutputHelper _output;
        private readonly NgoDbContext _ngoContext;

        private readonly INgoServices _ngoServices;
        private readonly IDonorServices _donorServices;
        private readonly IDonationServices _donationServices;
        private readonly IDonationRequestServices _donationRequestServices;

        public readonly Mock<INgoRepository> ngoservice = new Mock<INgoRepository>();
        public readonly Mock<IDonorRepository> donorservice = new Mock<IDonorRepository>();
        public readonly Mock<IDonationRepository> donationservice = new Mock<IDonationRepository>();
        public readonly Mock<IDonationRequestRepository> donationRequestservice = new Mock<IDonationRequestRepository>();

        private readonly NgoDetails _ngoDetails;
        private readonly Donor _donor;
        private readonly Donation _donation;
        private readonly DonationRequest _donationRequest;

        private readonly RegisterNgoViewModel _registerNgoViewModel;
        private readonly RegisterDonorViewModel _registerDonorViewModel;
        private readonly RegisterDonationViewModel _registerDonationViewModel;
        private readonly RegisterDonationRequestViewModel _registerDonationRequestViewModel;
        private static string type = "Boundary";
        public BoundaryTest(ITestOutputHelper output)
        {
            _ngoServices = new NgoServices(ngoservice.Object, _ngoContext);
            _donorServices = new DonorServices(donorservice.Object, _ngoContext);
            _donationServices = new DonationServices(donationservice.Object, _ngoContext);
            _donationRequestServices = new DonationRequestServices(donationRequestservice.Object, _ngoContext);
            _output = output;

            _ngoDetails = new NgoDetails
            {
                NgoId = 1,
                Name = "Ngo1",
                Username = "Ngo_UN",
                Password = "Pass123",
                Address = "Mumbai,Maharastra",
                Phone = "9632584754",
                StartedIn = DateTime.Now,
                FilePath = "file.txt",
                IsDeleted = false
            };
            _donor = new Donor
            {
                DonorId = 1,
                Name = "Donor1",
                Username = "Donor_UN",
                Password = "Pass123",
                Email = "Donor1@gmail.com",
                Address = "Pune,Maharashtra",
                Phone = "9435231423",
                IsDeleted = false,
                NgoId = 1
            };
            _donation = new Donation
            {
                DonationId = 1,
                Type = "DonationType1",
                Amount = 1000,
                Date = DateTime.Now,
                IsDeleted = false,
                NgoId = 1,
                DonorId = 1,

            };
            _donationRequest = new DonationRequest
            {
                DonationRequestId = 1,
                Amount = 2000,
                Status = "Done",
                EndDate = DateTime.Now,
                IsDeleted = false,
                NgoId = 1,
                DonorId = 1,
                DonationId = 1
            };
            _registerNgoViewModel = new RegisterNgoViewModel
            {
                NgoId = 1,
                Name = "Ngo1",
                Username = "Ngo_UN",
                Password = "Pass123",
                Address = "Mumbai,Maharastra",
                Phone = "9632584754",
                StartedIn = DateTime.Now,
                FilePath = "file.txt",
                IsDeleted = false
            };
            _registerDonorViewModel = new RegisterDonorViewModel
            {
                DonorId = 1,
                Name = "Donor1",
                Username = "Donor_UN",
                Password = "Pass123",
                Email = "Donor1@gmail.com",
                Address = "Pune,Maharashtra",
                Phone = "9435231423",
                IsDeleted = false,
                NgoId = 1
            };
            _registerDonationViewModel = new RegisterDonationViewModel
            {
                DonationId = 1,
                Type = "DonationType1",
                Amount = 1000,
                Date = DateTime.Now,
                IsDeleted = false,
                NgoId = 1,
                DonorId = 1,
            };
            _registerDonationRequestViewModel = new RegisterDonationRequestViewModel
            {
                DonationRequestId = 1,
                Amount = 2000,
                Status = "Done",
                EndDate = DateTime.Now,
                IsDeleted = false,
                NgoId = 1,
                DonorId = 1,
                DonationId = 1
            };
        }

        /// <summary>
        ///  Testfor_ValidEmail to test email id is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidEmail()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                
                //Assert
                donorservice.Setup(repo => repo.Register(_donor,_donor.Password)).ReturnsAsync(_donor);
                var result = await _donorServices.Register(_donor, _donor.Password);
                var actualLength = _donor.Email.ToString().Length;
                if (result.Email.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                //final result save in text file if exception raised
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //final result save in text file, Call rest API to save test result
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        /// <summary>
        /// Testfor_ValidateMobileNumber is used for test mobile number is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_ValidateMobileNumber()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                ngoservice.Setup(repo => repo.Register(_ngoDetails, _ngoDetails.Password)).ReturnsAsync(_ngoDetails);
                var result = await _ngoServices.Register(_ngoDetails, _ngoDetails.Password);
                var actualLength = _ngoDetails.Phone.ToString().Length;
                if (result.Phone.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                //final result save in text file if exception raised
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //final result save in text file, Call rest API to save test result
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        /// <summary>
        /// Test to validate Ngo Start Date connaot be blanks.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Ngo_StartDate_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            //Act
            try
            {
                ngoservice.Setup(repo => repo.Register(_ngoDetails,_ngoDetails.Password)).ReturnsAsync(_ngoDetails);
                var result = await _ngoServices.Register(_ngoDetails,_ngoDetails.Password);
                var actualLength = _ngoDetails.StartedIn.ToString().Length;
                if (result.StartedIn.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                //final result save in text file if exception raised
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            //final result save in text file, Call rest API to save test result
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }
    }
}
