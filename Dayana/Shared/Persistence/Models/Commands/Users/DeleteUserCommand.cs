﻿using Dayana.Shared.Basic.MethodsAndObjects.Models;
using Dayana.Shared.Infrastructure.Operations;
using MediatR;

namespace Dayana.Shared.Persistence.Models.Commands.Users;

public class DeleteUserCommand : IRequestInfo, IRequest<OperationResult>
{
    public DeleteUserCommand(RequestInfo requestInfo)
    {
        RequestInfo = requestInfo;
    }

    public int UserId { get; set; }
    public RequestInfo RequestInfo { get; private set; }
}