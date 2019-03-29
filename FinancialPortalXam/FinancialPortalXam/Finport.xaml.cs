using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinancialPortalXam
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Finport : ContentPage
	{
        public List<HouseHold> Houses = new List<HouseHold>();

		public Finport()
		{
        
			InitializeComponent();
            Title = "Welcome To FinPort";
            gethouseHoldBtn.Clicked += GetHouseHoldBtn_Clicked;
            
        }

        private async void GetHouseHoldBtn_Clicked(object sender, EventArgs e)
        {
             Houses = await Core.GetHouseHolds();
             MyListView.ItemsSource = Houses;
           
        }
        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)               
                return;

            int houseId = ((HouseHold)e.Item).Id;

            await Navigation.PushAsync(new NavigationPage(new AccountsPage(houseId)));
        }
    }
}