// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.IO;
using UnityEditor;
using XRTK.Editor;
using XRTK.Extensions;
using XRTK.Utilities.Editor;

namespace XRTK.Lenovo.Editor
{
    [InitializeOnLoad]
    internal static class LenovoPackageInstaller
    {
        private static readonly string DefaultPath = $"{MixedRealityPreferences.ProfileGenerationPath}Lenovo";
        private static readonly string HiddenPath = Path.GetFullPath($"{PathFinderUtility.ResolvePath<IPathFinder>(typeof(LenovoPathFinder)).ToForwardSlashes()}\\{MixedRealityPreferences.HIDDEN_PROFILES_PATH}");

        static LenovoPackageInstaller()
        {
            if (!EditorPreferences.Get($"{nameof(LenovoPackageInstaller)}", false))
            {
                EditorPreferences.Set($"{nameof(LenovoPackageInstaller)}", PackageInstaller.TryInstallAssets(HiddenPath, DefaultPath));
            }
        }
    }
}
