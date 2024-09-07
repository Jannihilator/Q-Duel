using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource SFXSource;
    [SerializeField] AudioSource MusicSource;
    public AudioClip jump;
    public AudioClip die;
    public AudioClip ship;
    public AudioClip red;
    public AudioClip pursue;
    public AudioClip win;
    public AudioClip respawn;
    public AudioClip cliff;
    // Start is called before the first frame update

    public void PlaySFX(AudioClip clip, float volume){
        SFXSource.PlayOneShot(clip, volume);
    }
}
