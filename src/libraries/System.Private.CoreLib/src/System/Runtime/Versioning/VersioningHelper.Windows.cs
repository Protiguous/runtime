// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Runtime.Versioning
{
    public static partial class VersioningHelper
    {
        private static int GetCurrentProcessId() => unchecked((int)Interop.Kernel32.GetCurrentProcessId());
    }
}
