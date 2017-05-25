// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Graph.RBAC.Fluent
{
    using Microsoft.Azure.Management.Graph.RBAC.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

    /// <summary>
    /// An immutable client-side representation of an Azure AD group.
    /// </summary>
    public interface IActiveDirectoryGroup  :
        IBeta,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasInner<Microsoft.Azure.Management.Graph.RBAC.Fluent.Models.ADGroupInner>
    {
        /// <summary>
        /// Gets mail field.
        /// </summary>
        string Mail { get; }

        /// <summary>
        /// Gets object Id.
        /// </summary>
        string ObjectId { get; }

        /// <summary>
        /// Gets security enabled field.
        /// </summary>
        bool SecurityEnabled { get; }

        /// <summary>
        /// Gets group display name.
        /// </summary>
        string DisplayName { get; }

        /// <summary>
        /// Gets object type.
        /// </summary>
        string ObjectType { get; }
    }
}