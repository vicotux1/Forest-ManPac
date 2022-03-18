using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GM_sound : MonoBehaviour{
	public static GM_sound GMsound;
    public AudioMixer audiomixer;
	AudioSource Audio;
	
	[Header ("Audioclips")]
	public AudioClip Coin_Sound,Winner_Sound,Loose_Sound,Next_level_sound;
    
	private void Awake() {
		Audio=GetComponent<AudioSource>();
		if (GMsound!=null){
    Destroy(this.gameObject);      
    }else{GMsound=this;
    DontDestroyOnLoad(this.gameObject);
    Debug.Log("esto es un singleton Sound");
	}
}
	public void SoundCoin(int One) {
		if (One== 0){
		Audio.clip = Coin_Sound;
		Audio.Play();
	}if (One== 1){
		Audio.clip = Loose_Sound;
		Audio.Play();
	}if (One== 2){
		Audio.clip = Winner_Sound;
		Audio.Play();
	}if (One== 3){
		Audio.clip = Next_level_sound;
		Audio.Play();
	}

		
	}
    public void FxSound(float Fxvolumen){
       audiomixer.SetFloat("Fxvolumen",Fxvolumen) ;
    }
    public void MusicSound(float Musicvolumen){
       audiomixer.SetFloat("Soundvolumen",Musicvolumen) ;
    }
    public void cursortrue(bool cursor){
		Cursor.visible = cursor;
	}
} 

