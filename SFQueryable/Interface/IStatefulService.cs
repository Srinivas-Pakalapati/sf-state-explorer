﻿using Microsoft.ServiceFabric.Services.Remoting;
using Microsoft.ServiceFabric.Services.Remoting.FabricTransport;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestStatefulService
{
    public interface IStatefulService : IService
    {
        Task<List<string>> QueryState(string reliableCollectionsName);
    }
}