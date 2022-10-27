#region Previas
using UnityEngine; 
using System.Collections; 
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif
#endregion
public class CanvasPause : MonoBehaviour {
    public Canvas canvasPausa;
		#region Unity
	void Start(){
	canvasPausa.enabled = false;
	Time.timeScale = 1;
	}
	public void Pause(){
		
		canvasPausa.enabled = !canvasPausa.enabled;
        Time.timeScale = Time.timeScale == 0 ? 1: 0;
		//Cursor.visible= !true; 
		}

	void Update(){
		if (Input.GetButtonDown ("Cancel")){
			Pause();
		}
	}
	public void CursorTrue(){
		Cursor.visible = true; 
	}
	public void CursorFalse(){
		Cursor.visible = false; 
	}

	#endregion
}