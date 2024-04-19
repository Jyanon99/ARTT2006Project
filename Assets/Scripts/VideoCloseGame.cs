using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoCloseGame : MonoBehaviour
{
    [SerializeField]
    VideoPlayer myVideoPlay;

    // Start is called before the first frame update
    void Start()
    {
        myVideoPlay.loopPointReached += EndGameAfterPlayVideo;
    }

    void EndGameAfterPlayVideo(VideoPlayer player)
    {
        Debug.Log("close game!");
        Application.Quit();
    }

}
