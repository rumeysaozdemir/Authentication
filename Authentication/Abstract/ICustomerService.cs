﻿using Authentication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
