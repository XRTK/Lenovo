// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;
using UnityEngine.Scripting;

[assembly: Preserve]
[assembly: AlwaysLinkAssembly]

namespace XRTK.Definitions.Platforms
{
    /// <summary>
    /// Used by the XRTK to signal that the feature is available on the Lenovo A6 platform.
    /// </summary>
    [System.Runtime.InteropServices.Guid("B1CBD7BB-FCE5-434B-B799-6ECF85245F33")]
    public class A6Platform : BasePlatform
    {
        /// <inheritdoc />
        public override bool IsAvailable
        {
            get
            {
                return true;
            }
        }

        /// <inheritdoc />
        public override bool IsBuildTargetAvailable
        {
            get
            {
                return Application.isEditor;
            }
        }
    }
}
