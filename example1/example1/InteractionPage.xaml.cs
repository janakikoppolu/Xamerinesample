using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace example1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InteractionPage : ContentPage
	{
		public InteractionPage ()
		{
			InitializeComponent ();
		}

       
        private void Interactionbutton_Clicked(object sender, EventArgs e)
        {
            decimal result = Convert.ToDecimal(firstnumber.Text) + Convert.ToDecimal(secondnumber.Text);
            resultLabel.Text = result.ToString();
        }
    }
}