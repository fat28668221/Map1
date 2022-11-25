using UnityEngine;

namespace Justin
{
    /// <summary>
    /// 音效管理器
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class SoundManger : MonoBehaviour
    {
        public static SoundManger instance;
        private AudioSource aud;

        private void Awake()
        {
            instance = this;

            aud = GetComponent<AudioSource>();
        }

        public void PlaySound(AudioClip sound, Vector2 rangeVolume)
        {
            float volume = Random.Range(rangeVolume.x, rangeVolume.y);
            aud.PlayOneShot(sound, volume);
        }
    }
}



