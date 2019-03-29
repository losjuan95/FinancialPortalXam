using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialPortalXam
{
  
        public class HouseHold
        {
           
            public int Id { get; set; }
          
            public string Description { get; set; }
          
            public string Name { get; set; }
         
            public string Greeting { get; set; }

            public HouseHold()
            {
                Id = 0;
                Description = "";
                Name = "";
                Greeting = "";
            }
        }
        public class Account
        {
           
            public int Id { get; set; }
          
            public string Name { get; set; }
            
            public int HouseHoldId { get; set; }
          
            public decimal InitialBalance { get; set; }
            
            public decimal CurrentBalance { get; set; }
          
            public decimal ReconciledBalance { get; set; }
            
            public decimal LowBalanceLimit { get; set; }

            public Account()
            {
                Id = 0;
                Name = "";
                HouseHoldId = 0;
                InitialBalance = 0;
                CurrentBalance = 0;
                ReconciledBalance = 0;
                LowBalanceLimit = 0;
            }



        }
        
}

