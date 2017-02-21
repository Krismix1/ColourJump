using UnityEngine;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour 
{
    #region Public Fields
    public EventSystem eventSystem;
    public GameObject selectedGameObject;
    #endregion

    #region Private Fields
    private bool buttonSelected = false;
	#endregion
	
	#region Functions

	void Update () 
	{
		if(Input.GetAxisRaw("Vertical") != 0 && buttonSelected == false)
        {
            buttonSelected = true;
            eventSystem.SetSelectedGameObject(selectedGameObject);
        }
	}

    private void OnDisable()
    {
        buttonSelected = false;
    }

    #endregion
}
