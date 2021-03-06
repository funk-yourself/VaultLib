﻿// This file is part of VaultLib by heyitsleo.
// 
// Created: 09/27/2019 @ 3:23 PM.

using CoreLibraries.IO;
using System;
using System.IO;
using VaultLib.Core.Data;
using VaultLib.Core.Types.EA.Reflection;

namespace VaultLib.Core.Types
{
    public class VLTEnumType<T> : PrimitiveTypeBase where T : IConvertible
    {
        public VLTEnumType(VltClass @class, VltClassField field, VltCollection collection) : base(@class, field,
            collection)
        {
        }

        public VLTEnumType(VltClass @class, VltClassField field) : base(@class, field)
        {
        }

        public T Value { get; set; }

        public sealed override void Read(Vault vault, BinaryReader br)
        {
            Value = br.ReadEnum<T>();
        }

        public sealed override void Write(Vault vault, BinaryWriter bw)
        {
            bw.WriteEnum(Value);
        }

        public override IConvertible GetValue()
        {
            return Value;
        }

        public override void SetValue(IConvertible value)
        {
            Value = (T)value;
        }
    }
}