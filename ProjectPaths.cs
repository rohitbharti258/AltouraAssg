using System.Runtime.Versioning;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName="ProjectPaths",menuName="Scriptable")]
public class ProjectPaths : ScriptableObject
{
    public string videoBundlePath;
    public string glbBundlePath;

    public static ProjectPaths Instance{
        get{
            return Resources.Load<ProjectPaths>("ProjectPaths");
        }
    }
}
