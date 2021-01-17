using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for Buy.xaml
    /// </summary>
    public partial class Buy : UserControl
    {
        public Buy()
        {
            InitializeComponent();
        }


      
            private void SaveBuy(object sender, RoutedEventArgs e)
            {
                DataAccess db = new DataAccess();
            db.InsertBuy(Convert.ToInt32(supl_id.Text), Convert.ToInt32(prod_id.Text), prod_name.Text, Crop_id.Text, Crop_name.Text
           , season.Text, seedtype.Text, Convert.ToInt32(rate.Text), Convert.ToInt32(items.Text), company.Text, description.Text, exp_date.Text);

        }

    }
}
