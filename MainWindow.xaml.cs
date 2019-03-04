/*David
 * March 4th 2019
 * adding last and first name
 */
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

namespace _312576stringConcat
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

        private void btnConcat_Click(object sender, RoutedEventArgs e)
        {
            //local variable
            string fName, lName;
            string fullName;
            int yearBorn;

            //assign value
            //Concatenation
            fName = txtFirstName.Text;
            fName = fName.Trim();
            lName = txtLastName.Text;
            lName = lName.Trim();
            yearBorn = calBday.SelectedDate.Value.Year;

            //Concatenation
            fullName = fName + " " + lName;
            if (fullName == "David Laughton") 
            {
                if (yearBorn >= 2000)
                {
                    lblOutput.Content = "you must be the student, your name must be " + fullName + " " +
                        "Welcome to the student verson";

                }
                else
                {
                    //Do this if true
                    lblOutput.Content = "Hey cool dude, your name must be " + fullName +
                        "Welcome to the teacher verson";
                }
            }
            else
           
            //Output
                lblOutput.Content = fullName;
                fullName.Trim();

            
            
           
        }
    }
}
