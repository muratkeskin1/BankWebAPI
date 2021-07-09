﻿using BankWebAPI.Model.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankWebAPI.Service.CustomerService.BillService
{
    interface IBillService
    {
        Bill PayBillFee(string BillNumber);
        Bill GetBillByBillNumber(string BillNumber);
    }
}