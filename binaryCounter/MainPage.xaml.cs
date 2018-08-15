using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace binaryCounter
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

        int output = 0;                                                 // initializes the value of the output before the button is clicked.

        private void AddOneToOutput(object sender, RoutedEventArgs e)   //method that is called each time the MainPage.add1 button is clicked.
        {
            output = output + 1;                                        // increases the value of the output by 1 each time the button is clicked.

            String decimalOutput = Convert.ToString(output, 10);        // converts current value of MainPage.output to decimal form as a string.
            decimalCount.Text = decimalOutput;                          // displays decimal output string in the MainPage.decimalCount TextBlock.

            String binaryOutput = Convert.ToString(output, 2);          // converts current value of MainPage.output to binary form as a string.
            binaryCount.Text = binaryOutput;                            // displays binary output string in the MainPage.binaryCount TextBlock.
        }
    }
}
