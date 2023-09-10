using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;


public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Slider slider;


    // Update is called once per frame
    void Update()
    {
        slider.SetValueWithoutNotify((float)videoPlayer.time/(float)videoPlayer.clip.length);
    }

    public void OnMouseDownOnSlilder(){
        videoPlayer.Pause();//用于提升操作体验
    }

    public void OnMouseUpOnSlider(){
        videoPlayer.Play();//用于提升操作体验
    }

    public void OnSliderValueChanged(){
        videoPlayer.time = slider.value*videoPlayer.clip.length;
        // print($"{slider.value} {videoPlayer.time}");
    }
}
