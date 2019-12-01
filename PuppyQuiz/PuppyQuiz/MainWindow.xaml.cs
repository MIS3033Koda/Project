using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace PuppyQuiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            //declare variables
            string puppy = "Husky";

            // if (RedRB.IsChecked)

            //    {
            //      exit = true;
           //       MessageBoxImage.Show
            //    }

            //logic
            
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"https://dog.ceo/api/breed/{puppy}/images/random").Result;

                if (response.IsSuccessStatusCode)
                {
                    
                    var content = response.Content.ReadAsStringAsync().Result;
                    var dogPicture = JsonConvert.DeserializeObject<Dogbreed>(content);

                  

                    //txtDogBreed.Text
                    BitmapImage dogImage = new BitmapImage();
                    dogImage.BeginInit();
                    dogImage.UriSource = new Uri(dogPicture.message);
                    dogImage.EndInit();

                    //ListBoxName = dogPicture.message;


                }
                else
                {
                    MessageBox.Show("Error");
                }
                




            }
    }
}
    }
