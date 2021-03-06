﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Reflection;

namespace Microsoft.Azure.WebJobs.Script.Description
{
    public interface IFunctionEntryPointResolver
    {
        MethodInfo GetFunctionEntryPoint(IList<MethodInfo> declaredMethods);

        T GetFunctionEntryPoint<T>(IEnumerable<T> methods) where T : IMethodReference;
    }
}