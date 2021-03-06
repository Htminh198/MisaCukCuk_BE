﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MisaCukCuk_Data.Entities
{
    public class CustomerGroup
    {
        public Guid CustomerGroupId { get; set; }
        public string Id
        {
            get
            {
                return CustomerGroupId.ToString();
            }
        }
        public string CustomerGroupName { get; set; }
        public string Description { get; set; }
    }
}
