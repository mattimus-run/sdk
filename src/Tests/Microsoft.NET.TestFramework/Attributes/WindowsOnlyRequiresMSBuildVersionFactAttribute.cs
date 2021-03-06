// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.InteropServices;
using Xunit;

namespace Microsoft.NET.TestFramework
{
    public class WindowsOnlyRequiresMSBuildVersionFactAttribute : FactAttribute
    {
        public WindowsOnlyRequiresMSBuildVersionFactAttribute(string version)
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                this.Skip = "This test requires Windows to run";
            }

            RequiresMSBuildVersionTheoryAttribute.CheckForRequiredMSBuildVersion(this, version);
        }
    }
}
