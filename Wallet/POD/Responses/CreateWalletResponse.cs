﻿using System;
using System.Collections.Generic;
using System.Text;

using Monero.Client.Network;

namespace Monero.Client.Wallet.POD.Responses
{
    public class CreateWalletResponse : RpcResponse
    {
        public CreateWalletResult result { get; set; }
    }

    public class CreateWalletResult
    {
        // ...
    }
}