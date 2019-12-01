﻿using Newtonsoft.Json;
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
           



            // if (RedRB.IsChecked)

            //    {
            //      exit = true;
           //       MessageBoxImage.Show
            //    }

            //logic
            
           

        }
        private void SubmitBtn_Click_1(object sender, RoutedEventArgs e)

        {
            string puppy = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                
              

            
            
            if ("adam" == NameTB.Text.ToLower())
            {
                puppy="englishsheepdog";
                
                
            }
            else if (q5.SelectedItem == _19to30 && q6.SelectedItem == Mexican)
            {
                puppy="chihuahua";
                //get json puppy chihuahua
            }
            else if (q4.SelectedItem == Winter && q10.SelectedItem == ParksandRec)
            {
                puppy="husky";
                //get json puppy husky
            }
            else if (q4.SelectedItem == Summer)
            {
                puppy="goldenretriever";
            }
            else if (q4.SelectedItem == Fall)
            {
                puppy="bordercollie";
                //get json puppy border collie
            }
            else if (q3.SelectedItem == Giraffe)
            {
                puppy="greatdane";
                //get json puppy great dane
            }
            else
            {
                puppy="labrador";
                //get json puppy lab
            }

                HttpResponseMessage response = client.GetAsync($"https://dog.ceo/api/breed/{puppy}/images/random").Result;

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

        }

    }
}
