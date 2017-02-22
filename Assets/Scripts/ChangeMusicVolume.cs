using UnityEngine;

public class ChangeMusicVolume : MonoBehaviour 
{
    #region Public Fields
    public AudioSource[] audios;
    #endregion

    #region Private Fields
    private AudioManager AM;
    #endregion

    #region Functions

    void Start()
    {
        
    }

    private void Update()
    {
        if (AM == null)
        {
            AM = FindObjectOfType<AudioManager>();
        }
        foreach (AudioSource audio in audios)
        {
            audio.volume = AM.volume;
        }
    }

    #endregion
}
