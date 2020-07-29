using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioContainer : MonoBehaviour
{
    public AudioSource jumpSource;
    public AudioSource landSource;

    public AudioClip[] jumpClips;
    public AudioClip[] landClips;

    public void PlayJumpClips()
    {
        jumpSource.clip = jumpClips[Random.Range(0, jumpClips.Length)];
        jumpSource.Play();
    }

    public void PlayLandClips()
    {
        landSource.clip = landClips[Random.Range(0, landClips.Length)];
        landSource.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
