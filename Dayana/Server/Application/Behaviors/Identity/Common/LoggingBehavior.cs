﻿using Dayana.Shared.Infrastructure.Operations;
using MediatR;

namespace Dayana.Server.Application.Behaviors.Identity.Common;

public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, OperationResult> where TRequest : IRequest<OperationResult>
{
    private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;

    public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
    {
        _logger = logger;
    }

    public async Task<OperationResult> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<OperationResult> next)
    {
        var response = await next();

        if (response.Succeeded)
        {
            return new OperationResult(OperationResultStatus.Ok, value: response);
        }
        else
        {
            return new OperationResult(OperationResultStatus.UnProcessable);
        }
    }
}