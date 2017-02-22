using UnityEngine;

public class AudioManager : MonoBehaviour 
{
    #region Public Fields
    public float volume = 1;
    #endregion

    #region Private Fields
    #endregion

    #region Functions

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void OnValueChanged(float value)
    {
        volume = value;
    }
	
	#endregion
}
