﻿using VaultLib.Core.Types;

namespace VaultLib.Support.ProStreet.VLT
{
    [VLTTypeInfo(nameof(eENGINE_GROUP))]
    public enum eENGINE_GROUP
    {
        eENGINE_V4 = 0x0,
        eENGINE_V6 = 0x1,
        eENGINE_V8 = 0x2,
    }
}