﻿using Microsoft.AspNet.SignalR.Hubs;

namespace Adaptive.ReactiveTrader.Server.SignalR
{
    class ContextHolder : IContextHolder
    {
        private volatile IHubCallerConnectionContext _context;

        public IHubCallerConnectionContext Context
        {
            get { return _context; }
            set { _context = value; }
        }
    }
}