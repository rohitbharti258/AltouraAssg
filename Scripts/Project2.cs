using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Project2 : MonoBehaviour
{
    [SerializeField] ProjectPaths projectPaths;
    Teleport teleport;
    public GameObject imagePanel;

    private int step = 0;

    private string glbFileName = "GLB.glb";

    void Awake(){
            teleport = GetComponent<Teleport>();
    }
    void Start(){
        imagePanel.SetActive(false);
        StartCoroutine(LoadGLB());
        var textObject = Instantiate(Resources.Load<GameObject>("TextPrefab"));
        textObject.transform.SetParent(transform);
        textObject.transform.position = new Vector3(400f,525f,0f);
        StartCoroutine(wait());
        StartCoroutine(wait1());

    }
    IEnumerator wait(){
        yield return new WaitForSeconds(3f);
        imagePanel.SetActive(true);
        Debug.Log("in  wait");
    }
    IEnumerator wait1(){
        yield return new WaitForSeconds(5f);
        imagePanel.SetActive(false);
        SceneManager.LoadScene("Teleport");

        Debug.Log("in  wait");
    }

    public void Home(){
        SceneManager.LoadScene("Home");
    }

    IEnumerator LoadGLB(){
        yield return new WaitForSeconds(1f);

        var glbBundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath+"/"+projectPaths.glbBundlePath);
                Debug.Log("glb bundle "+glbBundle);
        
        if(glbBundle != null){
            var modelPrefab = glbBundle.LoadAsset<GameObject>(glbFileName);
            Debug.Log("model "+modelPrefab);
            if(modelPrefab!=null){
                var modelInstance = Instantiate(modelPrefab);
                // GameObject newobject = new GameObject("Object");
                // modelInstance.transform.parent =newobject.transform;
                // Debug.Log("model instance "+modelInstance);  
            }
            else{
                Debug.Log("Error to load glb model");
            }
        }
        else{
                Debug.Log("Error to load glb asset bundle");
        }
    }
}
