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
    public partial class Page3 : ContentPage
    {
        public List<string> shoplist { get; set; }
        public Page3()
        {
            InitializeComponent();
            shoplist = new List<string>();
        }

        private void additembutton_Clicked(object sender, EventArgs e)
        {
            shoplist.Add(additem.Text);
            shoplistview.ItemsSource = shoplist;
        }

        private void clrbutton_Clicked(object sender, EventArgs e)
        {
            shoplist = new List<string>();
            shoplistview.ItemsSource = new List<string>();
        }
    }
}