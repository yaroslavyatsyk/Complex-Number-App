using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Complex_Number_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Complex_Number a;
        Complex_Number b;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = new Complex_Number(double.Parse(FirstRealBox.Text), double.Parse(FirstImaginaryBox.Text));
                b = new Complex_Number(double.Parse(SecondRealBox.Text), double.Parse(SecondImaginaryBox.Text));
                Complex_Number result = new Complex_Number(0, 0);

              ComboBoxItem comboBoxItem = (ComboBoxItem)Operation.SelectedItem;

                string operation = comboBoxItem.Content.ToString();

                switch (operation)
                {
                    case "+":
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "*":
                        result = a * b;
                        break;
                    case "/":
                        result = a / b;
                        break;
                }

          


                ResReal.Text = result.Real.ToString();
                ResIm.Text = result.Imaginary.ToString();

               



            }
            catch (FormatException ex)
            {
                string message = "Must be entered a valid number. Please try again.";
               MessageDialog messageDialog = new MessageDialog(message);
                messageDialog.ShowAsync();
            }
            catch (DivideByZeroException ex)
            {
                string message = "Cannot divide by zero. Please try again.";
                MessageDialog messageDialog = new MessageDialog(message);
                messageDialog.ShowAsync();
            }
        }
    }
}
