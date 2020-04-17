﻿/*
 * Shadowsocks-Net https://github.com/shadowsocks/Shadowsocks-Net
 */

using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using System.Buffers;
using System.Linq;
using System.IO;
using Microsoft.Extensions.Logging;
using Argument.Check;
using System.Text;

namespace Shadowsocks.Tunnel.Quic
{
    using Infrastructure;
    using Infrastructure.Sockets;
    using Infrastructure.Pipe;

    [Tunnel("Tunnel.Quic")]
    public class TunnelRemote : ITunnelRemote
    {
        public Task<IClient> AcceptTcp()
        {
            throw new NotImplementedException();
        }

        public Task<IClient> AcceptUdp()
        {
            throw new NotImplementedException();
        }
    }
}