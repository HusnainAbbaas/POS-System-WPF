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
using Dapper;
namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for test.xaml
    /// </summary>
    public partial class test : Page
    {
        List<person> people = new List<person>();
        public test()
        {
            InitializeComponent();
            //DataBoxLarge.DataContext = people;
            //DataBoxLarge.DisplayMemberPath= "FullInfo";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataAccess d = new DataAccess();
           // people=d.GetPeople(sBox.Text);
            //DataBoxLarge.Items.Add(people);

        }

        
        
      
        private void send(object sender, RoutedEventArgs e)
        {
            //DataAccess db = new DataAccess();
            //db.InsertSell(sBox_Copy1.Text, sBox_Copy2.Text,sBox_Copy3.Text);


        }
    }
}
