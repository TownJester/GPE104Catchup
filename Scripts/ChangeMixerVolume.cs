using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ChangeMixerVolume : MonoBehaviour
{
    public AudioMixer MainMixer;
    public Slider MusicVolume;
    public Slider EffectVolume; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnMusicVolumeChange();
        OnEffectVolumeChange();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMusicVolumeChange(){
        float NewVolume = MusicVolume.value;
        if (NewVolume <= 0){
            NewVolume = -80;
        }
        else{
            NewVolume = Mathf.Log10(NewVolume);
            NewVolume = NewVolume * 20;
        }
        MainMixer.SetFloat("AudioVolume", NewVolume);
    }
    public void OnEffectVolumeChange(){
        float NewVolume = EffectVolume.value;
        if (NewVolume <= 0){
            NewVolume = -80;
        }
        else{
            NewVolume = Mathf.Log10(NewVolume);
            NewVolume = NewVolume * 20;
        }
        MainMixer.SetFloat("SfxVolume", NewVolume);

    }
}
