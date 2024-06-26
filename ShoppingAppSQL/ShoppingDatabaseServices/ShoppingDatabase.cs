using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensions.Extensions;
using SQLitePCL;
using ShoppingAppSQL.DataBaseItems;

namespace ShoppingAppSQL.ShoppingDatabaseServices
{
    public class ShoppingDatabase
    {
        private SQLiteConnection _dbConnection;

        public string GetDatabasePath()
        {
            string filename = "shoppingdata.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(pathToDb, filename);
        }

        public ShoppingDatabase()
        {

            _dbConnection = new SQLiteConnection(GetDatabasePath());

            _dbConnection.CreateTable<Client>();
            _dbConnection.CreateTable<ClientType>();
            _dbConnection.CreateTable<SkincareItems>();
            _dbConnection.CreateTable<CartItem>();

            SeedDatabase();
        }

        public void SeedDatabase()
        {
            if (_dbConnection.Table<ClientType>().Count() == 0)
            {

                ClientType clientType = new ClientType()
                {
                    ClientTypeDescription = "Cash Client"
                };

                _dbConnection.Insert(clientType);

                clientType = new ClientType()
                {
                    ClientTypeDescription = "Credit Account Holder"
                };

                _dbConnection.Insert(clientType);

                if (_dbConnection.Table<Client>().Count() == 0)
                {

                    Client client = new Client()
                    {
                        ClientName = "",
                        ClientSurname = "",
                        ClientEmail = "",
                        ContactNumber = "",
                        ClientPassword = "",
                    };

                    _dbConnection.Insert(client);
                }

                if (_dbConnection.Table<SkincareItems>().Count() == 0)
                {
                    List<SkincareItems> foodItems = new List<SkincareItems>()
                    {
                         new SkincareItems()
                {
                 SkincareImage = "oil_cleanser.png",
                  SkincareName = "CeraVe Hydrating Foaming Oil Cleanser 236ml",
                 SkincarePrice = 265,
                  SkincareQuantity = 150,
                 SkincareDescription = "CeraVe Foaming cleansing gel thoroughly cleanses the skin. It effectively removes dirt, make-up and oil without attacking the skin's natural protection. It contains a combination of three essential ceramides 1, 3 and 6-ii, which build the skin's protection barrier and make the skin soft and velvety. The contained Niacinamide (vitamins B3) regulates the fat content of the skin and also strengthens it.\r\n\r\n",
                 },

                 new SkincareItems()
                {
                  SkincareImage = "hydrating_cleanser.png",
                  SkincareName = "CeraVe Hydrating Facial Cleanser 236ml",
                  SkincarePrice = 235,
                  SkincareQuantity = 150,
                  SkincareDescription = "Cerave Hydrating Facial Cleanser effectively cleanses, hydrates and helps restore the protective skin barrier. This non foaming lotion gently removes dirt and oil while increasing skin hydration after just one use.",
                 },


                 new SkincareItems()
                 {
                     SkincareImage = "spf_fifty.png",
                     SkincareName = "Nivea Sun SPF50+ Protect & Moisture Spray 200ml ",
                     SkincarePrice = 215,
                     SkincareQuantity = 150,
                     SkincareDescription = "Nivea Sun SPF50+ Moisturising Sun Spray 200ml is a long-lasting and water-resistant moisturising sun spray. It comes with a UVA-UVB protection system that takes immediate effect to guard against sun damage.",
                 },

                 new SkincareItems()
                  {
                     SkincareImage = "tinted_moisturiser.png",
                     SkincareName = "La Roche-Posay Anthelios Invisible Tinted Fluid SPf50",
                     SkincarePrice = 350,
                     SkincareQuantity = 150,
                     SkincareDescription = "La Roche-Posay Anthelios Invisible Tinted Fluid SPF50 50ml is a non-greasy sunscreen with an ultra-light moisturising texture that easily absorbs into the skin. Ideal for normal, combination or oily skin types with any skin sensitivities.",
                         },

                 new SkincareItems()
                 {
                     SkincareImage = "nivea_moisturiser.png",
                     SkincareName = "Nivea Rich Nourishing Body Moisturiser 625ml",
                     SkincarePrice = 120,
                     SkincareQuantity = 150,
                     SkincareDescription = "Nivea Rich Nourishing Body Moisturiser Dry Skin is specially formulated with Hydra IQ and almond oil to intensively nourish the skin and leave it soft, supple and comfortable."
                         },

                 new SkincareItems()
                 {
                     SkincareImage = "hyaluronic_acid_serum.png",
                     SkincareName = "The Ordinary Hyaluronic Acid 2% + B5 30ml",
                     SkincarePrice = 150,
                     SkincareQuantity = 150,
                     SkincareDescription = "Hyaluronic Acid 2% + B5 provides instant plumping hydration to give softer, smoother, healthy-looking skin. The lightweight formula replenishes skin�s hydration levels with all-day results, and helps the skin retain moisture to replump dry, dehydrated skin. Hyaluronic Acid 2% + B5 also promotes skin suppleness and elasticity, while minimising the appearance of fine dry lines.",
                 },

                  new SkincareItems()
                  {
                     SkincareImage = "aha_bha_serum.png",
                     SkincareName = "The Ordinary AHA 30% + BHA 2% Peeling Solution",
                     SkincarePrice = 22,
                     SkincareQuantity = 150,
                     SkincareDescription = "AHA 30% + BHA 2% Peeling Solution exfoliates multiple layers of the skin for a brighter, more even appearance. With the help of alpha-hydroxy acids (AHA), beta-hydroxy acids (BHA), and a studied Tasmanian pepperberry derivative, which reduces irritation that can be associated with acid use, this at-home peel helps even skin texture, clear pore congestion, and improve uneven pigmentation. The formula is further supported with a crosspolymer form of hyaluronic acid for comfort, pro-vitamin B5 for hydration, and black carrot for added protection.",
                  },

                  new SkincareItems()
                  {
                      SkincareImage = "skincare_set.png",
                      SkincareName = "The Ordinary The Bright Set",
                      SkincarePrice = 600,
                      SkincareQuantity = 150,
                      SkincareDescription = "A healthy glow requires a holistic approach. The Bright Set includes key formulas to target uneven skin tone and dullness. The Squalane Cleanser is a moisturizing makeup-removing cleanser that is gentle enough for everyday use. The Caffeine Solution 5% + EGCG targets dark circles and puffiness around the eye contour. Ethylated Ascorbic Acid 15% Solution is an antioxidant formula that aims to even skin tone. AHA 30% + BHA 2% Peeling Solution exfoliates multiple layers of the skin for a brighter, more even appearance. Glycolic Acid 7% Toning Solution is an exfoliant targeted at the surface of the skin. It helps improve skin clarity, balance uneven skin tone, and correct texture over time.",
                  },
                    };

                    _dbConnection.InsertAll(foodItems);

                }





            }


        }

        public List<ClientType> GetAllClientTypes()
        {
            var clientTypes = _dbConnection.Table<ClientType>().ToList();

            return clientTypes;
        }

        public List<Client> GetAllClients()
        {
            return _dbConnection.Table<Client>().ToList();
        }

        public void UpdateClient(Client client)
        {
            _dbConnection.Update(client);
        }

        public Client GetClientById(int id)
        {
            Client client = _dbConnection.Table<Client>().Where(x => x.ClientId == id).FirstOrDefault();

            if (client != null)
                _dbConnection.GetChildren(client, true);

            return client;
        }
        public List<SkincareItems> GetFoodItems()
        {
            return _dbConnection.Table<SkincareItems>().ToList();
        }
        public List<CartItem> GetCartItems()
        {
            return _dbConnection.Table<CartItem>().ToList();
        }

        public SkincareItems GetItemById(int id)
        {
            SkincareItems foodItems = _dbConnection.Table<SkincareItems>().Where(x => x.SkincareItemId == id).FirstOrDefault();

            if (foodItems != null)
                _dbConnection.GetChildren(foodItems, true);

            return foodItems;
        }
        public void AddToDataBase(CartItem cartItem) //Add Item from from db to cart
        {
            _dbConnection.Insert(cartItem);
        }
        public void DeleteFromDataBase(CartItem cartItem) //Remove Item from from cart to db
        {
            _dbConnection.Delete(cartItem);
        }
    }
}