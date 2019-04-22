using System;
using Microsoft.Extensions.Hosting;

namespace FGODex.Application.Contract.Background
{
    public interface IBackgroundServices: IHostedService, IDisposable
    {
    }
}
