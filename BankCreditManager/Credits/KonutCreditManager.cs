﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCrediService
{
    class KonutCreditManager : ICreditService
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }
    }
}
