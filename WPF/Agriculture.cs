using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{

    //public class person
    //{
    //    public string name { get; set; }
    //    public int id { get; set; }
    //    public string phone { get; set; }

    //}

    public class Address
        {

            public string street { get; set; }
            public string city { get; set; }
            public string country { get; set; }

            //public Address(string st,string a,string c) {

            //    //street = st;
            //    //city = a;
            //    //country = c;



            //}

        }

       public class crop
        {

            public string Crop_name { get; set; }
            public int crop_id { get; set; }
            public string SeedType { get; set; }
            public string SeaSon { get; set; }


        }

     public   class product
        {
        product() { }
            public int id;
            public string name { get; set; }
            public string company_name { get; set; }
            public string description { get; set; }
            public int items { get; set; }
            public int batch_no { get; set; }
            public float cost_per_item { get; set; }
            public int total { get; set; }
            public float cultivation_area_size { get; set; }
            public string expireDate { get; set; }

        public int ProdID
        {
            set { this.id = value; }
        }

        public float Total
            {
                get { return this.items * this.cost_per_item; }

            }




        }

     public  class customer 
        {
        public customer() { }
        public string credit { get; set; }

        public int ProdId;
        public string prod_name { get; set; }
        public string company_name { get; set; }
        public string description { get; set; }
        public int items { get; set; }
        public int batch_no { get; set; }
        public float cost_per_item { get; set; }
        public int total { get; set; }
        public float cultivation_area_size { get; set; }
        public string expireDate { get; set; }


        public string land_area { get; set; }
           // public product prod;
        
          //  public Address ad;
           // public crop cr;
            public string date { get; set; }

       

            //public float Total
            //{
            //    get { return this.prod.items * prod.cost_per_item; }
            //}



            //public string Display()
            //{

            //    return this.name + "    " + this.id + "     " + this.ad.Street + " " + this.ad.City + " " + this.ad.Country + "        " + "          " + this.prod.Name + "    " + this.prod.Id + "        " + this.prod.companyName + "           " + this.prod.Expire + "            " + this.prod.Batch + "        " + this.prod.Item + "        " + this.prod.Cost;

            //}

          
        }
    
    }


//        //class suppliers : person
//        //{


////    public Address ad;
////    public product prod;



////    public int Id
////    {
////        get { return this.id; }
////        set { this.id = value; }
////    }
////    public string Name
////    {
////        get { return this.name; }
////        set { this.name = value; }
////    }






////    public string Display()
////    {

////        return this.name + "    " + this.id + "     " + this.ad.Street + " " + this.ad.City + " " + this.ad.Country + "        " + "   " + this.prod.Name + "          " + this.prod.Id + "            " + this.prod.companyName + "            " + this.prod.Expire + "            " + this.prod.Batch + "         " + this.prod.Item + "        " + this.prod.Cost;

////    }





////}

////class CashBook
////{
////    public string Income_Date;
////    public string Income_Item;
////    public string Income_Description;
////    public float Income_Amount;

////    public string Expend_Date;
////    public string Expend_Item;
////    public string Expend_Description;
////    public float Expend_Amount = 0;


////    public float Total;

////}


////        class Program
////        {
////            static void Main(string[] args)
////            {

////                product p1 = new product();
////                Address ad = new Address();
////                crop cr = new crop();
////                //suppliers sup = new suppliers();
////                //CashBook CBook = new CashBook();

////                List<customer> cust = new List<customer>();
////                //List<suppliers> suppl = new List<suppliers>();
////                //List<CashBook> Income = new List<CashBook>();
////                //List<CashBook> Expend = new List<CashBook>();




////                //FileStream CustomerFile = new FileStream("E:\\CustomerWrite.txt", FileMode.Append, FileAccess.Write);
////                //StreamWriter CustomerWrite = new StreamWriter(CustomerFile);

////                //FileStream SupplierFile = new FileStream("E:\\SuppliersWrite.txt", FileMode.Append, FileAccess.Write);
////                //StreamWriter SupplierWrite = new StreamWriter(SupplierFile);

////                //FileStream IncomeFile = new FileStream("E:\\IncomeWrite.txt", FileMode.Append, FileAccess.Write);
////                //StreamWriter IncomeWrit = new StreamWriter(IncomeFile);

////                //FileStream ExpendFile = new FileStream("E:\\ExpendWrite.txt", FileMode.Append, FileAccess.Write);
////                //StreamWriter ExpendWrite = new StreamWriter(ExpendFile);





////                string custm = "y";
////                string menu = "n";
////                string purchase = "y";
////                char ch = ' ';
////                for (int j = 0; menu != "y"; j++)
////                {

////                    Console.WriteLine("----------------------------------------------------------------POS------------------------------------------------------------------");
////                    Console.WriteLine("1 : SALE ");
////                    Console.WriteLine("2 : Purchase ");
////                    Console.WriteLine("3 : Cash Book ");
////                    Console.WriteLine("4 : Display Data");

////                    int opt = Convert.ToInt32(Console.ReadLine());

////                    if (opt == 1)
////                    {

////                        for (int i = 0; custm != "n"; i++)
////                        {

////                            //////////////////Customer Section////////////////////////

////                            Console.WriteLine("Enter name of customer");
////                            string Name = Console.ReadLine();
////                            Console.WriteLine("Enter id of customer");
////                            int Id = Convert.ToInt32(Console.ReadLine());
////                            Console.WriteLine("Enter phone of customer");
////                            string phone = Console.ReadLine();
////                            Console.WriteLine("Enter Current Date");
////                            string date = Console.ReadLine();
////                            Console.WriteLine("Enter LandArea of customer");
////                            string Land = Console.ReadLine();


////                            ///////////////////Product Section////////////

////                            Console.WriteLine("Enter Product Name");
////                            p1.Name = Console.ReadLine();
////                            Console.WriteLine("Enter id of product");
////                            p1.Id = Convert.ToInt32(Console.ReadLine());
////                            Console.WriteLine("Enter company name");
////                            p1.companyName = Console.ReadLine();
////                            Console.WriteLine("Enter Expire Date");
////                            p1.Expire = Console.ReadLine();
////                            Console.WriteLine("Enter number of items");
////                            p1.Item = Convert.ToInt32(Console.ReadLine());
////                            Console.WriteLine("Enter batch number");
////                            p1.Batch = Convert.ToInt32(Console.ReadLine());
////                            Console.WriteLine("Enter cost_per_item");
////                            p1.Cost = Convert.ToInt32(Console.ReadLine());


////                            ///////////////////////////////////////////// Cash Book List  /////////////////////////////////////////////////////

////                            //Income.Add(new CashBook());
////                            //Income[i].Income_Amount = p1.Cost * p1.cost_per_item;
////                            //Income[i].Income_Item = p1.Name;
////                            //Income[i].Income_Date = date;
////                            //Income[i].Income_Description = p1.Name + "is Rice Supray made by" + p1.companyName;


////                            ///////////////////////////////////////////                 //////////////////////////////////////////






////                            ////////////////////////////////////////////Send INcome Data in File///////////////////////////////////////////////////

////                            //IncomeWrit.WriteLine(Income[i].Income_Date + "           " + Income[i].Income_Amount + "            " + Income[i].Income_Description + "        " + Income[i].Income_Item);
////                            //IncomeWrit.Flush();
////                            //IncomeWrit.Close();
////                            //IncomeWrit.Close();







////                            /////////////////////Address Section/////////////////////////



////                            Console.WriteLine("Enter city");
////                            ad.City = Console.ReadLine();

////                            Console.WriteLine("Enter Country");
////                            ad.Country = Console.ReadLine();

////                            Console.WriteLine("Enter street");
////                            ad.Street = Console.ReadLine();

////                            //////////////////////CRop Section////////////////////////////////
////                            Console.WriteLine("Enter Crop id of customer");
////                            cr.cropId = Convert.ToInt32(Console.ReadLine());

////                            Console.WriteLine("Enter Crop Name");
////                            cr.Crop_Name = Console.ReadLine();

////                            Console.WriteLine("Enter Seed Type");
////                            cr.SEEDType = Console.ReadLine();

////                            Console.WriteLine("Enter Season");
////                            cr.Season = Console.ReadLine();


////                            //////////////////////////////////////Add cutomers objects in list /////////////////////////////////// 

////                            cust.Add(new customer());
////                            cust[i].Id = Id;
////                            cust[i].Date = date;
////                            cust[i].Name = Name;
////                            cust[i].Land = Land;
////                            cust[i].ad = ad;
////                            cust[i].prod = p1;
////                            cust[i].cr = cr;


////                            ///////////////////////////////////////////send data in file//////////////////////////////////////



////                            //CustomerWrite.WriteLine(cust[i].Name + "    " + cust[i].Id + "     " + cust[i].ad.Street + " " + cust[i].ad.City + " " + cust[i].ad.Country + "        " + "          " + cust[i].prod.Name + "    " + cust[i].prod.Id + "        " + cust[i].prod.companyName + "           " + cust[i].prod.Expire + "            " + cust[i].prod.Batch + "        " + cust[i].prod.Item + "        " + cust[i].prod.Cost);
////                            //CustomerWrite.Flush();
////                            //CustomerWrite.Close();
////                            //CustomerWrite.Close();







////                            ////////////////////////////////////////////////////////////////////////////////////////////////////////


////                            Console.WriteLine("do you want to enter more record  (y/n)");
////                            custm = Console.ReadLine();

////                        }

////                    }

////                    else if (opt == 2)
////                    {

////                        for (int i = 0; purchase != "n"; i++)
////                        {

////                            Console.WriteLine("Enter name of supplier");
////                            string Name = Console.ReadLine();
////                            Console.WriteLine("Enter id of supplier");
////                            int Id = Convert.ToInt32(Console.ReadLine());
////                            Console.WriteLine("Enter phone of supplier");
////                            string phone = Console.ReadLine();



////                            Console.WriteLine("Enter city");
////                            ad.City = Console.ReadLine();

////                            Console.WriteLine("Enter Country");
////                            ad.Country = Console.ReadLine();

////                            Console.WriteLine("Enter street");
////                            ad.Street = Console.ReadLine();




////                            Console.WriteLine("Enter Product Name");
////                            p1.Name = Console.ReadLine();
////                            Console.WriteLine("Enter id of product");
////                            p1.Id = Convert.ToInt32(Console.ReadLine());
////                            Console.WriteLine("Enter company name");
////                            p1.companyName = Console.ReadLine();
////                            Console.WriteLine("Enter Expire Date");
////                            p1.Expire = Console.ReadLine();
////                            Console.WriteLine("Enter number of items");
////                            p1.Item = Convert.ToInt32(Console.ReadLine());
////                            Console.WriteLine("Enter batch number");
////                            p1.Batch = Convert.ToInt32(Console.ReadLine());
////                            Console.WriteLine("Enter cost_per_item");
////                            p1.Cost = Convert.ToInt32(Console.ReadLine());
////                            Console.WriteLine("Enter Current Date");
////                            string date = Console.ReadLine();




////                            ///////////////////////////////////////////// Add Cash Books in List   /////////////////////////////////////////////////////

////                            //float sum = 0;
////                            //Expend.Add(new CashBook());
////                            //Expend[i].Expend_Amount = p1.Cost * p1.cost_per_item;
////                            //Expend[i].Expend_Item = p1.Name;
////                            //Expend[i].Expend_Date = date;
////                            //Expend[i].Expend_Description = p1.Name + "is Rice Supray made by" + p1.companyName;

////                            //float a = 0;

////                            //for (int count = 0; count < 5; count++)
////                            //{

////                            //    sum = sum + Expend[count].Expend_Amount;


////                            //    CBook.Total = sum;
////                            //    break;


////                            //}






////                            //        /////////////////////////////////////////////////Send Expenditure Data in File//////////////////////////////////////////////

////                            //        ExpendWrite.WriteLine(Expend[i].Expend_Date + "           " + Expend[i].Expend_Amount + "            " + Expend[i].Expend_Description + "        " + Expend[i].Expend_Item);
////                            //        ExpendWrite.Flush();
////                            //        ExpendWrite.Close();
////                            //        ExpendWrite.Close();


////                            //        //////////////////////////////////////Add cutomers objects in list /////////////////////////////////// 


////                            //        suppl.Add(new suppliers());
////                            //        suppl[i].id = Id;
////                            //        suppl[i].name = Name;
////                            //        suppl[i].ad = ad;
////                            //        suppl[i].prod = p1;



////                            //        ////////////////////////////////////////       Send Suppliers Data in File///////////////////////////////////////////////////////


////                            //        SupplierWrite.WriteLine(suppl[i].Name + "    " + suppl[i].Id + "     " + suppl[i].ad.Street + " " + suppl[i].ad.City + " " + suppl[i].ad.Country + "        " + "          " + suppl[i].prod.Name + "    " + suppl[i].prod.Id + "        " + suppl[i].prod.companyName + "           " + suppl[i].prod.Expire + "            " + suppl[i].prod.Batch + "        " + suppl[i].prod.Item + "        " + suppl[i].prod.Cost);
////                            //        SupplierWrite.Flush();
////                            //        SupplierWrite.Close();
////                            //        SupplierWrite.Close();










////                            //        Console.WriteLine("do you want to enter more record  (y/n)");
////                            //        purchase = Console.ReadLine();

////                            //    }




////                            //}


////                            //else if (opt == 3)

////                            //{

////                            //    Console.WriteLine("---------------------------------------------Income------------------------------------------------------------");
////                            //    Console.WriteLine();
////                            //    Console.WriteLine();
////                            //    Console.WriteLine("Date                  Amount                        Description           Item\n");



////                            //    string[] income = File.ReadAllLines("E:\\IncomeRead.txt");

////                            //    foreach (string line in income)
////                            //        Console.WriteLine(line);




////                            //    Console.WriteLine("---------------------------------------------Expenditure------------------------------------------------------------");
////                            //    Console.WriteLine();
////                            //    Console.WriteLine();
////                            //    Console.WriteLine("Date                  Amount                        Description           Item\n");



////                            //    string[] expend = File.ReadAllLines("E:\\ExpendRead.txt");

////                            //    foreach (string line in expend)
////                            //        Console.WriteLine(line);














////                            //}






////                            //else if (opt == 4)
////                            //{
////                            //    /////////////////////////////Display Customers Data//////////////////////

////                            //    Console.WriteLine("Enter c for Customers Data;");
////                            //    Console.WriteLine("Enter s for Suppliers Data;");
////                            //    ch = Convert.ToChar(Console.ReadLine());

////                            //    if (ch == 'c')
////                            //    {

////                            //        Console.WriteLine();
////                            //        Console.WriteLine("Name      Id       Address         cropID      product_name    ProductId    CompanyName    ExpireDate     BatchNO    Items    PerItemCost \n");

////                            //        //foreach (customer c1 in cust)
////                            //        //    Console.WriteLine(c1.Display());

////                            //        string[] lines = File.ReadAllLines("E:\\CustomerRead.txt");

////                            //        foreach (string line in lines)
////                            //            Console.WriteLine(line);

////                            //    }

////                            //    if (ch == 's')
////                            //    {
////                            //        Console.WriteLine();
////                            //        Console.WriteLine("Name      Id       Address        product_name    ProductId    CompanyName    ExpireDate     BatchNO    Items    PerItemCost \n");

////                            //        //foreach (suppliers s1 in suppl)
////                            //        //    Console.WriteLine(s1.Display());


////                            //        string[] lines = File.ReadAllLines("E:\\SuppliersRead.txt");

////                            //        foreach (string line in lines)
////                            //            Console.WriteLine(line);


////                            //    }

////                            //}


////                            Console.WriteLine("Do you want to Exit;");
////                            menu = Console.ReadLine();




////                        }


////                        Console.ReadKey();

////                    }

////                }
////            }












////        }
////    }
////}