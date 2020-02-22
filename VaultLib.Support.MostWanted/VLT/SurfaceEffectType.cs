﻿using VaultLib.Core.Types;

namespace VaultLib.Support.MostWanted.VLT
{
    [VLTTypeInfo(nameof(SurfaceEffectType))]
    public enum SurfaceEffectType
    {
        kSine = 0x0,
        kSquare = 0x1,
        kTriangle = 0x2,
    }
}