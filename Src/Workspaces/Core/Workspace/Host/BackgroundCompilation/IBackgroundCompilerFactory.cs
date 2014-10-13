﻿// Copyright (c) Microsoft Open Technologies, Inc.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.Text;
using Microsoft.CodeAnalysis.WorkspaceServices;

namespace Microsoft.CodeAnalysis.Host
{
    internal interface IBackgroundCompilerFactory : IWorkspaceService
    {
        /// <summary>
        /// Creates a new background compiler that builds projects of the specified workspace asynchronously.
        /// </summary>
        IBackgroundCompiler CreateBackgroundCompiler(Workspace workspace);
    }
}