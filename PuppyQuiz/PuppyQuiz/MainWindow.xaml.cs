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
           

        }
        private void SubmitBtn_Click_1(object sender, RoutedEventArgs e)

        {
            string puppy = string.Empty;

            using (HttpClient client = new HttpClient())
            {
                // these if statments will show the results of the quiz based off user answers

                if ("adam" == NameTB.Text.ToLower())
                {

                  
                    puppy = "sheepdog";
                    //get json puppy sheepdog
                    DogLB.Items.Add("Sheepdog");
                    //shows the name Sheepdog

                }
                else if (q5.SelectedItem == _19to30 && q6.SelectedItem == Mexican)
                {
                    puppy = "chihuahua";
                    DogLB.Items.Add("Chihuahua");
                    //get json puppy chihuahua
                }
                else if (q4.SelectedItem == Winter && q10.SelectedItem == ParksandRec)
                {
                    puppy = "husky";
                    //get json puppy husky
                    DogLB.Items.Add("Husky");
                    //shows the name Husky
                }
                else if (q4.SelectedItem == Summer)
                {
                    puppy = "retriever";
                    //get json puppy retriever
                    DogLB.Items.Add("Retriever");
                    //shows the name Golden Retriever
                }
                else if (q4.SelectedItem == Fall)
                {
                    puppy = "collie";
                    //get json puppy collie
                    DogLB.Items.Add("Collie");
                    //shows the name collie
                }
                else if (q3.SelectedItem == Giraffe)
                {
                    puppy = "dane";
                    //get json puppy great dane
                    DogLB.Items.Add("Great Dane");
                    //shows the name great dane
                }
                else
                {
                    puppy = "labrador";
                    //get json puppy labrador
                    DogLB.Items.Add("Labrador");
                    //shows the name labrador
                }

                HttpResponseMessage response = client.GetAsync($"https://dog.ceo/api/breed/{puppy}/images/random").Result;
                //if the link comes back correctly with the breed type, then it calls the image on that api to show in the image box
                if (response.IsSuccessStatusCode)
                {

                    var content = response.Content.ReadAsStringAsync().Result;
                    var dogPicture = JsonConvert.DeserializeObject<Dogbreed>(content);


                    BitmapImage dogImage = new BitmapImage();
                    dogImage.BeginInit();
                    dogImage.UriSource = new Uri(dogPicture.message);
                    dogImage.EndInit();

                    DogImage.Source = dogImage;


                }
                else
                {
                    MessageBox.Show("Error");
                }


            }
            DogLB.Items.Clear();
            NameTB.Clear();
            q2.Text = "";
            q3.Text = "";
            q4.Text = "";
            q5.Text = "";
            q6.Text = "";
            q7.Text = "";
            q8.Text = "";
            q9.Text = "";
            q10.Text = "";

        }

    }
}
