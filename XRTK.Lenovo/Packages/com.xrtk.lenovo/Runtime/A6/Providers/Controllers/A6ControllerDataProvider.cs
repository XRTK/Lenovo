// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Attributes;
using XRTK.Definitions.Platforms;
using XRTK.Interfaces.InputSystem;
using XRTK.Lenovo.A6.Profiles;
using XRTK.Providers.Controllers;

namespace XRTK.Lenovo.A6.Providers.Controllers
{
    [RuntimePlatform(typeof(A6Platform))]
    [System.Runtime.InteropServices.Guid("82049A8B-EE38-47B5-B301-17DF7708B57B")]
    public class A6ControllerDataProvider : BaseControllerDataProvider
    {
        /// <inheritdoc />
        public A6ControllerDataProvider(string name, uint priority, A6ControllerDataProviderProfile profile, IMixedRealityInputSystem parentService)
            : base(name, priority, profile, parentService)
        {
        }
    }
}
