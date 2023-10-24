using UnityEngine;

//got the code from (https://www.youtube.com/watch?v=N8whM1GjH4w&t=102s&ab_channel=RehopeGames) and learnt to do this in class

public class AudioManager : MonoBehaviour
{
   [SerializeField] AudioSource musicSource;
   [SerializeField] AudioSource SFXSource;

   [Header("-----------Audio Clip----------")]
    public AudioClip Background;

    public AudioClip Death;

    public AudioClip Shoot;

    public AudioClip PowerUp;

    public AudioClip Button;

    private void Start()
    {
        musicSource.clip = Background; // once game starts, background music will play
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip); //plays audio clip once
    }
}
