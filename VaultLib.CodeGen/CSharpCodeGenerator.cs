﻿// This file is part of VaultLib.CodeGen by heyitsleo.
// 
// Created: 11/29/2019 @ 9:35 PM.

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using VaultLib.Core;
using VaultLib.Core.Data;
using VaultLib.Core.DB;
using VaultLib.Core.Types;
using VaultLib.Core.Types.Abstractions;
using VaultLib.Core.Types.EA.Reflection;
using VaultLib.Core.Utils;

namespace VaultLib.CodeGen
{
    public class CSharpCodeGenerator
    {
        private readonly Database _database;

        public CSharpCodeGenerator(Database database)
        {
            _database = database;
        }

        /// <summary>
        /// Generates a C# wrapper for the given VLT class and writes it to a file in the given directory
        /// </summary>
        /// <param name="vltClass">The <see cref="VLTClass"/> to generate code for</param>
        /// <param name="directory">The directory to create the code file in</param>
        public void WriteCodeToFile(VLTClass vltClass, string directory)
        {
            File.WriteAllText(Path.Combine(directory, $"{GetClassName(vltClass)}.gen.cs"), GenerateCode(vltClass));
        }

        /// <summary>
        /// Generates the code
        /// </summary>
        /// <param name="vltClass">The <see cref="VLTClass"/> to generate code for</param>
        /// <returns></returns>
        private string GenerateCode(VLTClass vltClass)
        {
            StringBuilder stringBuilder = new StringBuilder(1024);

            string className = GetClassName(vltClass);

            stringBuilder.AppendLine("using System.Collections.Generic;");
            stringBuilder.AppendLine("using VaultLib.CodeGen;");
            stringBuilder.AppendLine("using VaultLib.Core.Data;");
            stringBuilder.AppendLine($"// Generated by VaultLib.CodeGen @ {DateTime.Now:U} for game {_database.Game}");
            stringBuilder.AppendFormat("public class {0} : CollectionWrapperBase {{", className);
            stringBuilder.AppendLine();
            stringBuilder.AppendFormat("\tpublic {0}(VLTCollection collection) : base(collection) {{}}", className)
                .AppendLine();

            foreach (var vltClassField in vltClass.Fields.Values.OrderBy(GetAPIFieldName))
            {
                Type type = TypeRegistry.ResolveType(_database.Game, vltClassField.TypeName);
                //string typeName = type?.FullName ?? "object";
                string typeName = "";

                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(VLTEnumType<>))
                {
                    type = type.GetGenericArguments()[0];
                }
                else if (type.DescendsFrom(typeof(PrimitiveTypeBase)))
                {
                    type = PrimitiveToRealPrimitive(type);
                } else if (type.DescendsFrom(typeof(BaseRefSpec)))
                {
                    type = typeof(RefSpecWrapper);
                }

                typeName = type?.FullName ?? "object";
                string fieldName = GetAPIFieldName(vltClassField);

                if (type == typeof(VLTUnknown))
                {
                    stringBuilder.AppendFormat("\t// unknown type: {0}", vltClassField.TypeName).AppendLine();
                }

                string returnTypeName = vltClassField.IsArray ? $"List<{typeName}>" : typeName;

                stringBuilder.AppendFormat("\tpublic {0} {1}() {{", returnTypeName, fieldName).AppendLine();
                stringBuilder.AppendFormat("\t\treturn {2}<{0}>(\"{1}\");", typeName, vltClassField.Name, vltClassField.IsArray ? "GetArray" : "GetValue").AppendLine();
                stringBuilder.AppendFormat("\t}}").AppendLine();
            }

            stringBuilder.AppendLine("}");

            return stringBuilder.ToString();
        }

        private string GetClassName(VLTClass vltClass)
        {
            return $"{_database.Game}_{vltClass.Name}";
        }

        private static string GetAPIFieldName(VLTClassField vltClassField)
        {
            return vltClassField.Name.StartsWith("0x")
                ? $"field_{vltClassField.Name}"
                : vltClassField.Name;
        }

        private Type PrimitiveToRealPrimitive(Type type)
        {
            // class should be marked with an attribute
            if (type.GetCustomAttribute<PrimitiveInfoAttribute>() is PrimitiveInfoAttribute primInfo)
            {
                return primInfo.PrimitiveType;
            }

            throw new Exception($"cannot map {type.FullName} to primitive type");
        }
    }
}