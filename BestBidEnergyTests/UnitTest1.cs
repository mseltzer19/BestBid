using System;
using BestBidEnergy.Models;
using Xunit;

namespace bestbidenergytests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var auction = new Auction{
                AuctionID = 3,
                AuctionTime = DateTime.Now,
                ContractID = 5
            };

        }
        [Fact]
        public void Test2()
        {
            var contract = new Contract{
                ContractID = 3,
                BuyerUsername = "BobbyBuyer",
                SupplierUsername = "SallySupplier",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                Price = 3,
                Street = "NextDoor",
                City = "GoHeartYourOwnCity",
                State = "OH",
                Zip = "43210",
                UtilityAccount = "NotYourAverageAccount",
                UtilityArea = "Columbus",
                AvgkWh = 2000
            };

        }
        [Fact]
        public void Test3()
        {
            var buyer = new Buyer{
                Username = "Buyer333",
                Phone = "333-333-3333",
                Company = "CompanyABC",
                Account_Num = "3333333",
                Account_Type = "Residential",
                Credit_Rating = 333,
                Contact_Name = "404ThisContractDoesNotExist"
            };
        }
    }
}
