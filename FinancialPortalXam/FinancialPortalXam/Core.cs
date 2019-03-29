using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace FinancialPortalXam
{
    class Core
    {
        public static async Task<List<HouseHold>> GetHouseHolds()
        {

            string queryString = "https://finportapi.azurewebsites.net/GetAllHouseHolds";

            try
            {
                dynamic results = await DataService.getDataFromService(queryString).ConfigureAwait(false);

                if (results != null)
                {
                    var data = JsonConvert.DeserializeObject<List<HouseHold>>(results.ToString());
                    return data;
                }

            }
            catch(Exception ex)
            {
                Log.Warning("Exception", ex.Message);
            }
            return null;
            
        }

        public static async Task<List<Account>> GetHouseHoldAccounts(int houseId)
        {

            string queryString = "https://finportapi.azurewebsites.net/api/Accounts?houseid=" + houseId;

            try
            {
                dynamic results = await DataService.getDataFromService(queryString).ConfigureAwait(false);


                if (results != null)
                {
                    string jsonstring = JsonConvert.SerializeObject(results);

                    var data = JsonConvert.DeserializeObject<List<Account>>(jsonstring);
                    return data;
                }

            }
            catch (Exception ex)
            {
                Log.Warning("Exception", ex.Message);
            }
            return null;

        }

    }
}
