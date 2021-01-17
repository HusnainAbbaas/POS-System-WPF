using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Collections.Specialized;
namespace WpfApp3
{

    public partial class User : UserControl
    {
        public User()
        {
            InitializeComponent();
        }

        private void Sell_record(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertSell(Convert.ToInt32(cust_id.Text),Convert.ToInt32(prod_id.Text),prod_name.Text,crop_id.Text,crop_name.Text
                ,season.Text,seed_type.Text, Convert.ToInt32(rate.Text), Convert.ToInt32(items.Text),company.Text,description.Text,exp_date.Text);

        }

        
    }
}
