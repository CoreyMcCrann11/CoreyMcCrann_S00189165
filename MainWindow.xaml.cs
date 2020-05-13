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

namespace CoreyMcCrann_S00189165
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LbxPhones_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from phones in db.Phones
                        select phones;

            lbxPhones.ItemsSource = query.ToList();

           
        }

        private void LbxPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone chosenPhone = lbxPhones.SelectedItem as Phone;
            
            if (chosenPhone != null)
            {
                tblkPrices.Text = $"{chosenPhone.Price}";
                PhoneImage.Source = new BitmapImage(new Uri(chosenPhone.Phone_Image, UriKind.Relative));
            }


        }
    }
}
