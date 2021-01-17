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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : UserControl
    {

        List<person> people = new List<person>();
        public Search()
        {
            InitializeComponent();
        }

        private void Searchdata(object sender, RoutedEventArgs e)
        {
            Search s = new Search();
            
                DataAccess db = new DataAccess();

                people = db.GetPeople(Convert.ToInt32(name.Text),tablename.Text);
                this.DataContext = s.people;
                this.listBoxx.ItemsSource = people;
           
            


            //DataBoxLarge.Items.Add(people);
        }
    }
}
