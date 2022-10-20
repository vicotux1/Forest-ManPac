#region Previas
using UnityEngine; 
using System.Collections; 
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
#endregion
public class pause_manager : MonoBehaviour {

	public void Resolution480p (){
		 Screen.SetResolution(848, 480, false);
		}
	public void Resolution600p (){
		 Screen.SetResolution(1024, 600, false);
		}	
		public void Resolution720p (){
		 Screen.SetResolution(1280, 720, false);
		}
		public void Resolution1080p (){
		 Screen.SetResolution(1920, 1080, false);
		}
	
    
	#region quality	
	public void Set_Quality(int Level){
		QualitySettings.antiAliasing = Level;
	}
	public void Get_Quality (int Level){
	QualitySettings.SetQualityLevel(Level);
	}

	
	public void scene(string name){ 
	SceneManager.LoadScene (name);
	}
	public void ShadowsLevel(int Level){
		if(Level==0){
		QualitySettings.shadows = ShadowQuality.Disable;
		}else if(Level==1){
		QualitySettings.shadows = ShadowQuality.HardOnly;		
		}else if(Level==2){
        QualitySettings.shadows = ShadowQuality.All;
		}
	
	}
	public void fullScreen(int Level){
	if(Level==0){
		Screen.fullScreen = false;
	}else if(Level==1){
		Screen.fullScreen = true;
	}
}
	public void Quit(){
     #if UNITY_EDITOR 
    EditorApplication.isPlaying = false;
    #else
    Application.Quit();
	#endif
	}
	#endregion
}