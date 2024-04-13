﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Utility
{
    public static class OrderStatus
    {

        public const string StatusPending = "Pending";
        public const string StatusRefunded = "Refunded";
        public const string StatusApproved = "Approved";
        public const string StatusCancelled = "Cancelled";
        public const string StatusInProcess = "UnderProcessing";
        public const string StatusShipped = "Shipped";
    }
}
