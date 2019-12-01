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
           
 //    if (FirstQuestion.IsPressed)
 //               {
 //  }               MessageBoxImage.Show();
 //
 //           
            //declare variables
            string puppy = string.Empty;



            // if (RedRB.IsChecked)

            //    {
            //      exit = true;
           //       MessageBoxImage.Show
            //    }

            //logic
            //--need json request - bitmapimage
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"https://dog.ceo/api/breed/{puppy}/images/random").Result;

                if (response.IsSuccessStatusCode)
                {
                    //check input - string.Contains
                    //If(UserInput == 
                    var content = response.Content.ReadAsStringAsync().Result;
                    var dogPicture = JsonConvert.DeserializeObject<Dogbreed>(content);



                    //txtDogBreed.Text
                    //BitmapImage dogImage = new BitmapImage();
                    //dogImage.BeginInit();
                    //dogImage.UriSource = new Uri(dogPicture.message);
                    //dogImage.EndInit();

                    MessageBox.Show(dogPicture.message);


                }
                else
                {
                    
                }
                



            }

        }
        private void SubmitBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if ("adam" == NameTB.Text.ToLower())
            {
                HttpResponseMessage response = client.GetAsync($"https://dog.ceo/api/breed/sheepadoodle/images/random").Result;
                MessageBox.Show(dogPicture.response);
                
            }
            else if (q2.SelectedItem == q2.19-30 && q6.SelectedItem == q2.Mexican)
            {
                //get json puppy chihuahua
            }
            else if (question)
        }

    }
}
