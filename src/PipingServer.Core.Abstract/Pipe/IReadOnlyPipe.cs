﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace PipingServer.Core.Pipes
{
    public interface IReadOnlyPipe : IPipe
    {
        ValueTask<IHeaderDictionary> GetHeadersAsync(CancellationToken Token = default);
        protected bool IsSetSenderComplete { get; }
        protected bool IsSetReceiversComplete { get; }
        PipeType IPipe.Required => (Status, IsSetSenderComplete, IsSetReceiversComplete) switch
        {
            (PipeStatus.Created, false, false) => PipeType.All,
            (PipeStatus.Wait, true, false) => PipeType.Receiver,
            (PipeStatus.Wait, false, true) => PipeType.Sender,
            _ => PipeType.None,
        };
        event PipeStatusChangeEventHandler? OnStatusChanged;
    }
}
