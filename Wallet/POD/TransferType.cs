﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoneroClient.Wallet.POD
{
    public enum TransferType
    {
        /// <summary>
        /// All the transfers.
        /// </summary>
        All,
        /// <summary>
        /// Only transfers which are not yet spent.
        /// </summary>
        Available,
        /// <summary>
        /// Only transfers which are already spent.
        /// </summary>
        Unavailable,
    }
}