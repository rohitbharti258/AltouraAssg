using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System;
using UnityEngine.SceneManagement;

public class Project1 : MonoBehaviour
{
    
    [SerializeField] private ProjectPaths projectPaths;
    private VideoPlayer videoPlayer;
    private GameObject videoPlayerGO;
    private string videoFilePath = "big_buck_bunny_720p_1mb.mp4";
    private double pausedTime;

    void Start(){
        videoPlayerGO = new GameObject("VideoPlayer");
        videoPlayer = videoPlayerGO.AddComponent<VideoPlayer>();
        var videoBundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath+"/"+projectPaths.videoBundlePath);
        Debug.Log("Video Bundle "+videoBundle);
        videoPlayer.url = Application.streamingAssetsPath + "/" + videoFilePath;
        StartVideo();
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space)){
            PauseVideo();
        }
    }
    public void StartVideo()
    {
        videoPlayer.time = pausedTime;
        videoPlayer.Play();
    }

    public void PauseVideo()
    {
        if(videoPlayer.isPlaying)
            videoPlayer.Pause();
            pausedTime = videoPlayer.time;
    }

    public void StopVideo()
    {
        videoPlayer.Stop();
    }    
}
