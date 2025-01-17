// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;

namespace Microsoft.Health.Core;

public static class Clock
{
    public static DateTimeOffset UtcNow => UtcNowFunc();

    internal static Func<DateTimeOffset> UtcNowFunc { get; set; } = () => DateTimeOffset.UtcNow;
}
