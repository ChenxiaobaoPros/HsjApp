using Hsj.AppControls.Iconfonts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HsjAppExample
{
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            #region 实验
            //byte[] by=  charToByte('\ue800');

            //string str = $"\ue800"; //$"{char}"; 
            //this.Content = new Label { Text = str, FontFamily = "iconize-entypoplus.ttf#" };
            /*********************************************/

            //string str = $"{(char)Unicode.ep_500px}"; //$"{char}"; 
            //this.Content = new Label { Text = str, FontFamily = "iconize-entypoplus.ttf#" };
            #endregion


        }
        public static byte[] charToByte(char c)
        {
            byte[] b = new byte[2];
            b[0] = (byte)((c & 0xFF00) >> 8);
            b[1] = (byte)(c & 0xFF);
            return b;
        }
        public static char byteToChar(byte[] b)
        {
            char c = (char)(((b[0] & 0xFF) << 8) | (b[1] & 0xFF));
            return c;
        }

        private void IconGrop_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IconfontPage());
        }
    }
}
