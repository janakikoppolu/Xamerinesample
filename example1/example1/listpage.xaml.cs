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
	public partial class listpage : ContentPage
	{
        private List<string> shoplist;

        public listpage ()
		{
			InitializeComponent ();
            shoplist = new List<string>();
		}

        private void addbutton_Clicked(object sender, EventArgs e)
        {
            object newitemEntry = null;
            if (String.IsNullOrEmpty(Addingnewitem.Text))
            {

          
            }
            else
            {
                shoplist.Add()
            }
        }

        private void additembutton_Clicked(object sender, EventArgs e)
        {

        }

        private void clrbutton_Clicked(object sender, EventArgs e)
        {

        }
    }
}