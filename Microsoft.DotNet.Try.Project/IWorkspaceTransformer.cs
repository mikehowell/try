// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Microsoft.DotNet.Try.Protocol;

namespace Microsoft.DotNet.Try.Project
{
    public interface IWorkspaceTransformer
    {
        Task<Workspace> TransformAsync(Workspace source);
    }
}