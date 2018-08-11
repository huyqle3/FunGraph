using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    #region Singleton

    public static SoundManager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public AudioSource audioSource;
    public AudioClip expectoPatronum;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayAudioClip(string audioName)
    {
        if (VRWandControls.instance.currentSpell == "Expelliarmus") {
            AudioClip audioClip = Resources.Load("AudioClips/" + audioName) as AudioClip;
            audioSource.PlayOneShot(audioClip);
        }
    }
}
