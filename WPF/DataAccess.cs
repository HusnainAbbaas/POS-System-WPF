using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
namespace WpfApp3
{
    class DataAccess
    {

        public List<person> GetPeople(int id ,string Table)
        {

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConVal("Agriculture")))
            {
                var output = connection.Query<person>($"select * from {Table} where cust_id = '{ id}'").ToList();
                // var output = connection.Query<person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
        }

        public void InsertSell(int cust_id, int prod_id, string prod_name , string crop_id   , string  crop_name   
         , string season  , string seed_type   , int  rate   , int items, string company  , string description   ,string exp_date)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConVal("Agriculture")))
            {
               
                
                
                List<sell> sell_1 = new List<sell>();


                sell_1.Add( new sell { id = cust_id, ProdId = prod_id , prod_name=prod_name,cropid
                = crop_id, cropname =crop_name , season = season , seed_type = seed_type
                ,
                    items = items, rate = rate , company_name=company, description= description
                });



                connection.Execute("dbo.Sellrec @id, @ProdId , @prod_name,@cropid, @cropname,@season," +
                    " @seed_type, @items,@rate,   @company_name, @description",  sell_1) ;
                
            }
        }

        public void InsertBuy(int cust_id, int prod_id, string prod_name, string crop_id, string crop_name
             , string season, string seed_type, int rate, 
            int items, string company, string description, string exp_date)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConVal("Agriculture")))
            {



                List<sell> Buy_1 = new List<sell>();


                Buy_1.Add(new sell
                {
                    id = cust_id,
                    ProdId = prod_id,
                    prod_name = prod_name,
                    cropid
                = crop_id,
                    cropname = crop_name,
                    season = season,
                    seed_type = seed_type
                ,
                    items = items,
                    rate = rate,
                    company_name = company,
                    description = description
                });



                connection.Execute("dbo.BuyProc @id, @ProdId , @prod_name,@cropid, @cropname,@season," +
                    " @seed_type, @items,@rate,   @company_name",Buy_1);


            }
        }

        public void InsertCustomers(string cust_id, string  name, string phone, string address)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConVal("Agriculture")))
            {



                List<person> cust = new List<person>();


                cust.Add(new person
                {
                    Id = cust_id,
                    Name = name,
                   
                    PhoneNumber = phone,
                    Address = address
                });

                connection.Execute("dbo.Custrec @Id, @Name,@PhoneNumber , @Address", cust);

            }
        }

        public void InsertSuppliers(string cust_id, string name, string phone, string address)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConVal("Agriculture")))
            {



                List<person> cust = new List<person>();


                cust.Add(new person
                {
                    Id = cust_id,
                    Name = name,

                    PhoneNumber = phone,
                    Address = address
                });

                connection.Execute("dbo.Supllier_proc @Id, @Name,@PhoneNumber , @Address", cust);

            }
        }

      


    }
}
