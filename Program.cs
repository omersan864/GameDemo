using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;

namespace GameDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            CustomerManager Customer = new CustomerManager(new CustomerCheckManager());
            ICustomerService customer = new CustomerManager();
            customer.save(new Entities.Customer
            {
               Id= 1,
               DateOfBirth=new DateTime(2000,02,05),
               Name="ömer",
               LastName="şan",
               NatinonalityId="27655"
            });
            customer.update(new Entities.Customer
            {
                Id = 1,
                DateOfBirth = new DateTime(2000, 02, 05),
                Name = "ömer",
                LastName = "şan",
                NatinonalityId = "27655"
            });
            customer.delete(new Entities.Customer
            {
                Id = 1,
                DateOfBirth = new DateTime(2000, 02, 05),
                Name = "ömer",
                LastName = "şan",
                NatinonalityId = "27655"
            });

            IGameService game = new GameManager();
            game.save(new Game { GameName = "WarCraft", GameVersion = "Actions", IdGame = 1 });

            game.update(new Game { GameName = "WarCraft", GameVersion = "Actions", IdGame = 1 });

            game.delete(new Game { GameName = "WarCraft", GameVersion = "Actions", IdGame = 1 });


            ICampaignService campaign = new CampaignManager();
            campaign.save(new Campaign { CampainId = 1,CampainName="bedava",CampainDescription="ürün bal almayan ...." });

            campaign.update(new Campaign { CampainId = 1, CampainName = "bedava", CampainDescription = "ürün bal almayan ...." });

            campaign.delete(new Campaign { CampainId = 1, CampainName = "bedava", CampainDescription = "ürün bal almayan ...." });

            ISalesService sales = new SalesManager();
            sales.sales(
            new Customer
            {
                Name = "ömer",
            },
            new Game 
            {
                GameName = "WarCraft" ,
            });

        }
    }
}