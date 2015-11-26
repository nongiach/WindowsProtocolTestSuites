﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Smb2
{
    public class Smb2ClientUnlockRange
    {
        public uint Offset
        {
            get;
            set;
        }

        public uint Length
        {
            get;
            set;
        }
    }
}
