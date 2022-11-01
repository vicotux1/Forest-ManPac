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
	[SerializeField] GameManager gamanager;
	[SerializeField] Slider Slider_Music;
	[SerializeField] Slider Slider_SFX;


	private void Awake() {
	gamanager = FindObjectOfType<GameManager>();

		Slider_Music.value=gamanager.Musicvol;

		Slider_SFX.value=gamanager.SFXvol;

	}

		#region Unity
	void Start(){
	canvasPausa.enabled = false;
	Time.timeScale = 1;
	gamanager = FindObjectOfType<GameManager>();
	}
	public void Pause(){
		
		canvasPausa.enabled = !canvasPausa.enabled;
        Time.timeScale = Time.timeScale == 0 ? 1: 0;
		gamanager.Musicvol=Slider_Music.value;
		gamanager.SFXvol=Slider_SFX.value;
		}

	void Update(){

		if (Input.GetButtonDown ("Cancel")){
			Pause();
			}
		if (gamanager == null) {
			
            gamanager = FindObjectOfType<GameManager>();
            print("buscando Game manager");
		}	
	}
	public void CursorTrue(){
		Cursor.visible = true; 
	}
	public void CursorFalse(){
		Cursor.visible = false; 
	}
	public void DeadGame(){
		gamanager. DeadMain();	

	}

	#endregion
}