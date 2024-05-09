using System.Security.AccessControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class createAssetBundle : MonoBehaviour
{
    // Start is called before the first frame update
    [MenuItem("Assets/Build AssetBundles")]
    static void BuildAllAssetBundles()
    {
    string assetBundleDirectory = "Assets/StreamingAssets";
    if (!Directory.Exists(Application.streamingAssetsPath))
    {
        Directory.CreateDirectory(assetBundleDirectory);
    }
    BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
    }
}
