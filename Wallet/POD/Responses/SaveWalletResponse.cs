﻿using System;
using System.Collections.Generic;
using System.Text;

using Monero.Client.Network;

namespace Monero.Client.Wallet.POD.Responses
{
    public class SaveWalletResponse : RpcResponse
    {
        public SaveWalletResult result { get; set; }
    }

    public class SaveWalletResult
    {
        // ...
    }
}