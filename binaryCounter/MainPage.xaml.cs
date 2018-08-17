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

        int output = 0;                                                   // initializes the value of the output before the button is clicked


        public void AddOneToOutput(object sender, RoutedEventArgs e)      // method that is called each time the MainPage.add1 button is clicked
        {

            try
            {
                int decimalInput = Convert.ToInt32(inputBox.Text);

                if (decimalInput >= 0 && decimalInput <= 16382)                // executed each time the add1 button is clicked if the output will be 14 bits or less
                {
                    output = output + 1;

                    String decimalOutput = Convert.ToString(output, 10);        // converts current value of MainPage.output to decimal form as a string
                    decimalCount.Text = decimalOutput;                          // displays decimal output string in the MainPage.decimalCount TextBlock
                    inputBox.Text = decimalCount.Text;                          // ensures that inputBox displays the same value as decimalCount

                    String binaryOutput = Convert.ToString(output, 2);          // converts current value of MainPage.output to binary form as a string
                    binaryCount.Text = binaryOutput;                            // displays binary output string in the MainPage.binaryCount TextBlock

                    String hexidecimalOutput = Convert.ToString(output, 16);          // converts current value of MainPage.output to hexidecimal form as a string
                    hexidecimalCount.Text = hexidecimalOutput;                            // displays hexidecimal output string in the MainPage.hexidecimalCount TextBlock
                }
                else if (decimalInput < 0)                                      // clicking the add1 button with a negative input resets the value to zero
                {
                    decimalInput = 0;
                    output = decimalInput;

                    String decimalOutput = Convert.ToString(decimalInput, 10);
                    decimalCount.Text = decimalOutput;


                    String binaryOutput = Convert.ToString(decimalInput, 2);
                    binaryCount.Text = binaryOutput;

                    inputBox.Text = decimalCount.Text;
                }
                else
                {
                    //TODO make a congratulations message for reaching the limit of a 14 bit number.
                }
            }
            catch (OverflowException)                                       // sets value to zero if input is greater than 32 bit when add1 is clicked
            {
                int decimalInput = 0;
                output = decimalInput;

                String decimalOutput = Convert.ToString(decimalInput, 10);
                decimalCount.Text = decimalOutput;


                String binaryOutput = Convert.ToString(decimalInput, 2);
                binaryCount.Text = binaryOutput;

                String hexidecimalOutput = Convert.ToString(output, 16);
                hexidecimalCount.Text = hexidecimalOutput;

                inputBox.Text = decimalCount.Text;
            }
            catch (FormatException)                                         // sets value to zero if input is string when input is clicked
            {
                int decimalInput = 0;
                output = decimalInput;

                String decimalOutput = Convert.ToString(decimalInput, 10);
                decimalCount.Text = decimalOutput;


                String binaryOutput = Convert.ToString(decimalInput, 2);
                binaryCount.Text = binaryOutput;

                String hexidecimalOutput = Convert.ToString(output, 16);
                hexidecimalCount.Text = hexidecimalOutput;

                inputBox.Text = decimalCount.Text;
            }
        }

        public void ConvertClick(object sender, RoutedEventArgs e)          // event for clicking conversion button
        {
            try                                                             // succeeds if entered value is a 32 bit int
            {
                int decimalInput = Convert.ToInt32(inputBox.Text);          // converts input to int

                if (decimalInput >= 0 && decimalInput <= 16383)             // route for 14 bit int input
                {
                    output = decimalInput;

                    String decimalOutput = Convert.ToString(decimalInput, 10);
                    decimalCount.Text = decimalOutput;


                    String binaryOutput = Convert.ToString(decimalInput, 2);
                    binaryCount.Text = binaryOutput;

                    String hexidecimalOutput = Convert.ToString(output, 16);
                    hexidecimalCount.Text = hexidecimalOutput;
                }
                else if (decimalInput < 0)                                      // route for negative int input
                {
                    decimalInput = 0;                                           // resets to zero
                    output = decimalInput;

                    String decimalOutput = Convert.ToString(decimalInput, 10);
                    decimalCount.Text = decimalOutput;


                    String binaryOutput = Convert.ToString(decimalInput, 2);
                    binaryCount.Text = binaryOutput;

                    String hexidecimalOutput = Convert.ToString(output, 16);
                    hexidecimalCount.Text = hexidecimalOutput;

                    inputBox.Text = decimalCount.Text;
                }
                else                                                            // route for int greater than 14 bit, less than 33 bit
                {
                    decimalInput = 16383;                                       // sets value to max 14 bit value
                    output = decimalInput;

                    String decimalOutput = Convert.ToString(decimalInput, 10);
                    decimalCount.Text = decimalOutput;


                    String binaryOutput = Convert.ToString(decimalInput, 2);
                    binaryCount.Text = binaryOutput;

                    String hexidecimalOutput = Convert.ToString(output, 16);
                    hexidecimalCount.Text = hexidecimalOutput;

                    inputBox.Text = decimalCount.Text;
                }
            }
            catch (OverflowException)                                       // sets value to zero if input is greater than 32 bit when convert botton is clicked
            {
                int decimalInput = 0;
                output = decimalInput;

                String decimalOutput = Convert.ToString(decimalInput, 10);
                decimalCount.Text = decimalOutput;


                String binaryOutput = Convert.ToString(decimalInput, 2);
                binaryCount.Text = binaryOutput;

                String hexidecimalOutput = Convert.ToString(output, 16);
                hexidecimalCount.Text = hexidecimalOutput;

                inputBox.Text = decimalCount.Text;
            }
            catch (FormatException)                                         // sets value to zero if input is string when convert button is clicked
            {
                int decimalInput = 0;
                output = decimalInput;

                String decimalOutput = Convert.ToString(decimalInput, 10);
                decimalCount.Text = decimalOutput;


                String binaryOutput = Convert.ToString(decimalInput, 2);
                binaryCount.Text = binaryOutput;

                String hexidecimalOutput = Convert.ToString(output, 16);
                hexidecimalCount.Text = hexidecimalOutput;

                inputBox.Text = decimalCount.Text;
            }
        }
    }
}
