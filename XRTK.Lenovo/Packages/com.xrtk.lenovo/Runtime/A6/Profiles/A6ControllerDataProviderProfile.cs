// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Definitions.Controllers;
using XRTK.Definitions.Utilities;
using XRTK.Lenovo.A6.Providers.Controllers;

namespace XRTK.Lenovo.A6.Profiles
{
    public class A6ControllerDataProviderProfile : BaseMixedRealityControllerDataProviderProfile
    {
        public override ControllerDefinition[] GetDefaultControllerOptions()
        {
            return new[]
            {
                new ControllerDefinition(typeof(A6Controller), Handedness.Left),
                new ControllerDefinition(typeof(A6Controller), Handedness.Right)
            };
        }
    }
}
