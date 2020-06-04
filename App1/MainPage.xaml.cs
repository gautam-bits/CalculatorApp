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

namespace App1
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

        string ans = "0";
        string temp = "0";
        char opr = '+';
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ans += "1";
            resultANS.Text = ans;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ans += "2";
            resultANS.Text = ans;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ans += "3";
            resultANS.Text = ans;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ans += "4";
            resultANS.Text = ans;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ans += "5";
            resultANS.Text = ans;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ans += "6";
            resultANS.Text = ans;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ans += "7";
            resultANS.Text = ans;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ans += "8";
            resultANS.Text = ans;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            ans += "9";
            resultANS.Text = ans;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            ans += "0";
            resultANS.Text = ans;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            ans += "00";
            resultANS.Text = ans;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            ans = "0";
            temp = "0";
            resultANS.Text = ans ;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (ans.Length == 1) 
                ans = "0";
            else
                ans = ans.Substring(0,ans.Length - 1);

            resultANS.Text = ans;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (opr == '+')
                temp = (Int32.Parse(ans) + Int32.Parse(temp)).ToString();
            else if (opr == '-')
                temp = (Int32.Parse(temp) - Int32.Parse(ans)).ToString();
            else if (opr == '*')
                temp = (Int32.Parse(ans) * Int32.Parse(temp)).ToString();
            else if (opr == '/')
                temp = ((int)((float)Int32.Parse(temp) / (float)Int32.Parse(ans))).ToString();

            ans = "0";
            resultANS.Text = ans;
            opr = '+';

        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if (opr == '+')
                temp = (Int32.Parse(ans) + Int32.Parse(temp)).ToString();
            else if (opr == '-')
                temp = (Int32.Parse(temp) - Int32.Parse(ans)).ToString();
            else if (opr == '*')
                temp = (Int32.Parse(ans) * Int32.Parse(temp)).ToString();
            else if (opr == '/')
                temp = ((int)((float)Int32.Parse(temp) / (float)Int32.Parse(ans))).ToString();

            ans = "0";
            resultANS.Text = ans;
            opr = '/';
            
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            if (opr == '+')
                temp = (Int32.Parse(ans) + Int32.Parse(temp)).ToString();
            else if (opr == '-')
                temp = (Int32.Parse(temp) - Int32.Parse(ans)).ToString();
            else if (opr == '*')
                temp = (Int32.Parse(ans) * Int32.Parse(temp)).ToString();
            else if (opr == '/')
                temp = ((int)((float)Int32.Parse(temp) / (float)Int32.Parse(ans))).ToString();

            ans = "0";
            resultANS.Text = ans;
            opr = '*';
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            if (opr == '+')
                temp = (Int32.Parse(ans) + Int32.Parse(temp)).ToString();
            else if (opr == '-')
                temp = (Int32.Parse(temp) - Int32.Parse(ans)).ToString();
            else if (opr == '*')
                temp = (Int32.Parse(ans) * Int32.Parse(temp)).ToString();
            else if (opr == '/')
                temp = ((int)((float)Int32.Parse(temp) / (float)Int32.Parse(ans))).ToString();

            ans = "0";
            resultANS.Text = ans;
            opr = '-';
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            if (opr == '+')
                temp = (Int32.Parse(ans) + Int32.Parse(temp)).ToString();
            else if (opr == '-')
                temp = (Int32.Parse(temp) - Int32.Parse(ans)).ToString();
            else if (opr == '*')
                temp = (Int32.Parse(ans) * Int32.Parse(temp)).ToString();
            else if (opr == '/')
                temp = ((int)((float)Int32.Parse(temp) / (float)Int32.Parse(ans))).ToString();

            ans = temp;
            resultANS.Text = ans;
            temp = "0";
            opr = '+';

        }
    }
}
