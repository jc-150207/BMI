using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            double h = double.Parse(this.height.Text);
            double w = double.Parse(this.weight.Text);

            if (h >= 3)
            {
                h /= 100;
            }
            double bmi = w / h / h;

            string s;

            if (bmi >= 25)
            {
                s = "肥満";
            }
            else if ((bmi < 25) && (bmi > 18.5))
            {
                s = "標準体重";
            }
            else if (bmi <= 18.5)
            {
                s = "低体重";
            }
            else
            {
                s = "error";
            }

            DisplayAlert("BMI",s + "(" + bmi.ToString() + ")","OK");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
