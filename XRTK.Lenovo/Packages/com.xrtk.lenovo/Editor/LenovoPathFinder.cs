// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;
using XRTK.Utilities.Editor;

namespace XRTK.Lenovo.Editor
{
    /// <summary>
    /// Dummy scriptable object used to find the relative path of the com.xrtk.lenovo.
    /// </summary>
    ///// <inheritdoc cref="IPathFinder" />
    public class LenovoPathFinder : ScriptableObject, IPathFinder
    {
        ///// <inheritdoc />
        public string Location => $"/Editor/{nameof(LenovoPathFinder)}.cs";
    }
}


