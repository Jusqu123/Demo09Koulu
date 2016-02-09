using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Demo09teht1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void car_Click(object sender, RoutedEventArgs e)
        {
            string carsString = carnro.Text;

            int carInt = int.Parse(carsString);
             carInt++;
            carnro.Text = carInt.ToString();
            
        }

        private void truck_Click(object sender, RoutedEventArgs e)
        {
            string trucksString = trucknro.Text;

            int trucksInt = int.Parse(trucksString);
            trucksInt++;
            Debug.WriteLine("Trucks =" + trucksInt); // Saadaan tietoja output ikkuaan!!!
            trucknro.Text = trucksInt.ToString();

        }
    }
}
