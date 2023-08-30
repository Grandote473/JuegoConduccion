using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOnOff : MonoBehaviour
{
    private bool musicOnOff;
    private GameObject music;
    // Start is called before the first frame update
    void Start()
    {
        music = GameObject.FindGameObjectWithTag("Music");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnOff()
    {
        if (musicOnOff)
        {
            music.GetComponent<AudioSource>().mute = false;
            musicOnOff = false;
        }else if(musicOnOff == false)
        {
            music.GetComponent<AudioSource>().mute = true;
            musicOnOff = true;
        }
    }
}
