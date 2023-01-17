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

namespace Appl
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

        private void Calculate_Btn_Click(object sender, RoutedEventArgs e)
        {
            if(Calculate_Options.SelectedIndex == 0) // '0' indicates the sides with exterior angle option
            {
                if(Exterior_Angle_Textbox.Text != "")
                {
                    int exteriorAngle = Int32.Parse(Exterior_Angle_Textbox.Text);
                    int answer = 360 / exteriorAngle;
                    Sides_Textbox.Text = answer.ToString();
                }
            }

            else if(Calculate_Options.SelectedIndex == 1)
            {
                if(Interior_Angle_Textbox.Text != "")
                {
                    int interiorAngle = Int32.Parse(Interior_Angle_Textbox.Text);
                    int answer = 360 / (180 - interiorAngle);
                    Sides_Textbox.Text = answer.ToString();
                }
            }
        }
    }
}