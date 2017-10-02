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
        public List<string> shoplist=new List<string>();


        public listpage ()
		{
			InitializeComponent();
            shoplist = new List<string>();
		}

     

        private void additembutton_Clicked(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(additem.Text))
            {

          
            }
            else
            {
                shoplist.Add(additem.Text);
                shoplistlist.ItemSource = shoplist;
                additem.Text = "";

            }
        }

        private void clrbutton_Clicked(object sender, EventArgs e)
        {
            shoplist = new List<string>();
            shoplistlist.ItemSource = shoplist;
        }
    }
}