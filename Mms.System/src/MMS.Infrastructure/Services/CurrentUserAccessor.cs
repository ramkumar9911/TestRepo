﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using MMS.Application.Common.Interfaces;

namespace MMS.Infrastructure.Services;

public class CurrentUserAccessor : ICurrentUserAccessor
{
    private readonly ClaimsPrincipal _user;

    public CurrentUserAccessor()
    {
        _user = new ClaimsPrincipal();
    }
    public string? UserId => _user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    public string? TenantId => _user.FindFirst(ClaimTypes.GroupSid)?.Value;
}

