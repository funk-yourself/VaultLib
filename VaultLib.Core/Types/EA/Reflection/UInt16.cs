﻿// This file is part of VaultLib by heyitsleo.
// 
// Created: 09/26/2019 @ 4:27 PM.

using System;
using System.IO;
using VaultLib.Core.Data;

namespace VaultLib.Core.Types.EA.Reflection
{
    [VLTTypeInfo("EA::Reflection::UInt16")]
    [PrimitiveInfo(typeof(ushort))]
    public class UInt16 : PrimitiveTypeBase
    {
        public UInt16(VltClass @class, VltClassField field, VltCollection collection) : base(@class, field, collection)
        {
        }

        public UInt16(VltClass @class, VltClassField field) : base(@class, field)
        {
        }

        public ushort Value { get; set; }

        public override void Read(Vault vault, BinaryReader br)
        {
            Value = br.ReadUInt16();
        }

        public override void Write(Vault vault, BinaryWriter bw)
        {
            bw.Write(Value);
        }

        public override IConvertible GetValue()
        {
            return Value;
        }

        public override void SetValue(IConvertible value)
        {
            Value = (ushort)value;
        }
    }
}