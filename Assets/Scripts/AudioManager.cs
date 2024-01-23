using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    private static AudioManager _instance = null;

    public static AudioManager Instance => _instance;

    [SerializeField] AudioClip flySound;
    [SerializeField] AudioClip dieSound;
    [SerializeField] AudioClip gainScoreSound;
    [SerializeField] AudioClip startSound;
    [SerializeField] AudioClip levelSound;

    private void Awake()
    {
        // Singleton
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            _instance = this;
            this.transform.SetParent(null);
            DontDestroyOnLoad(this);
        }
    }

    public void PlayFly()
    {
        PlaySound(flySound, Random.Range(0.8f, 1.2f)); // pitch random entre 0.8 et 1
    }

    public void PlayDie()
    {
        PlaySound(dieSound);
    }

    public void PlayGainScore()
    {
        PlaySound(gainScoreSound, 1.5f);
    }

    public void PlayStart()
    {
        PlaySound(startSound, 0.6f);
    }

    public void PlayLevel()
    {
        PlaySound(levelSound);
    }

    public void PlaySound(AudioClip clip, float _pitch = 1, float _volume = 1)
    {
        AudioSource source = gameObject.AddComponent<AudioSource>();
        source.volume = _volume;
        source.pitch = _pitch;
        source.PlayOneShot(clip);
        Destroy(source, 3);
    }
}
