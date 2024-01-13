using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Complex_Number_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ResultPage : Page
    {
        public ResultPage()
        {
            this.InitializeComponent();
        }

        public ResultPage(string op, Complex_Number a, Complex_Number b, Complex_Number result)
        {
            this.InitializeComponent();
            this.Operation.Text = op;
            this.Real1.Text = a.Real.ToString();
            this.Imaginary1.Text = a.Imaginary.ToString();
            
            this.Real2.Text = b.Real.ToString();
            this.Imaginary2.Text = b.Imaginary.ToString();

            this.ResReal.Text = result.Real.ToString();
            this.ResIm.Text = result.Imaginary.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           CoreWindow.GetForCurrentThread().Close();
        }
    }
}
