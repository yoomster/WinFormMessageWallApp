﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormLibrary
{
    public class PersonModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<AddressModel> Addresses { get; set; }
    }
}
