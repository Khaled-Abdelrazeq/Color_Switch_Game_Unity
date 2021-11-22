using UnityEngine;
using UnityEngine.UI;

public class GameSound : MonoBehaviour
{
    [SerializeField] private Slider backgroundSoundSlider;
    public float musicVolume;

    public static GameSound Instance;

    private void Awake()
    {
        Instance = this;
        backgroundSoundSlider.value = PlayerPrefs.GetFloat("SoundVolume", 1);
    }


    private void Update()
    {
        musicVolume = backgroundSoundSlider.value;
        PlayerPrefs.SetFloat("SoundVolume", GameSound.Instance.musicVolume);
    }
}
