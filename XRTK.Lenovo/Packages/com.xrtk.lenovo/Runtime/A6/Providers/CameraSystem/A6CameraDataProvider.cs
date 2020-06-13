// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;
using UnityEngine.Scripting;
using XRTK.Attributes;
using XRTK.Definitions.CameraSystem;
using XRTK.Definitions.Platforms;
using XRTK.Interfaces.CameraSystem;
using XRTK.Providers.CameraSystem;

namespace XRTK.Lenovo.A6.Providers.CameraSystem
{
    [RuntimePlatform(typeof(A6Platform))]
    [System.Runtime.InteropServices.Guid("87225637-2EC7-4E5D-9036-024288BAA2BF")]
    public class A6CameraDataProvider : BaseCameraDataProvider
    {
        /// <inheritdoc />
        [Preserve]
        public A6CameraDataProvider(string name, uint priority, BaseMixedRealityCameraDataProviderProfile profile, IMixedRealityCameraSystem parentService)
            : base(name, priority, profile, parentService)
        {

        /// <inheritdoc />
        public override bool IsOpaque => false;
        }
    }
}
