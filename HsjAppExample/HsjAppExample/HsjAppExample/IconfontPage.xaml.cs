using Hsj.AppControls.Iconfonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HsjAppExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IconfontPage : ContentPage
	{
		public IconfontPage ()
		{
			InitializeComponent ();

            //foreach (var item in Enum.GetValues(typeof(Unicode)))
            //{
            //    var labelKey = new Label { Text = $"{(char)item}" };

            //    var labelValue = new Label { Text = $"{(char)item}" };

            //    stackLayout.Children.Add(


            //        );
            //}
            var items = Enum.GetValues(typeof(Unicode));

            var stackLyout = new StackLayout();
            for (int i = 0; i < items.Length; i++)
            {
                var item = items.GetValue(i);
                int str = (int)item;
                char car = (char)str;
                string strr = $"{car}";
                var labelValue = new Label { Text = strr,FontSize=30 ,FontFamily= "iconize-entypoplus.ttf#" };

                var labelKey = new Label { Text = item.ToString(), FontSize = 30 };

                var layout = new StackLayout { Orientation =StackOrientation.Horizontal};
                layout.Children.Add(labelKey);
                layout.Children.Add(labelValue);

                stackLyout.Children.Add(layout);
            }

            scrollView.Content = stackLyout;
        }
	}
}