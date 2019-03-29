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

	public partial class AccountsPage : ContentPage
	{
        public List<Account> Accounts = new List<Account>();

     

		public AccountsPage(int houseId)
		{
             
			InitializeComponent();
            Task.Run(async () =>
            {
                await GetAccounts(houseId);
            });
        }

        public async Task GetAccounts(int houseId)
        {
            Accounts = await Core.GetHouseHoldAccounts(houseId);
            MyListView.ItemsSource = Accounts;

        }
    }
}