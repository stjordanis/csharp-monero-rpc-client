﻿using System;
using System.Collections.Generic;
using System.Text;

using Monero.Client.Network;

namespace Monero.Client.Wallet.POD.Responses
{
    public class AccountTagAndDescriptionResponse : RpcResponse
    {
        public AccountTagAndDescriptionResult result { get; set; }
    }

    public class AccountTagAndDescriptionResult
    {
        // ...
    }
}