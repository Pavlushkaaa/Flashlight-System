using UnityEngine;

namespace PS.Flashlight
{
    /// <summary>
    /// Module that plays a sound when the state of the flashlight changes.
    /// </summary>
    [RequireComponent(typeof(ISwitchEvent), typeof(AudioSource))]
    [AddComponentMenu("Pavlushka Store/SoundPlayer")]
    public class SoundPlayer : MonoBehaviour
    {
        [SerializeField] private AudioClip[] _sounds;

        private AudioSource _audioSource;

        private ISwitchEvent _switchEvents;

        #region System
        private void OnEnable()
        {
            _switchEvents.OnEnabledEvent += PlaySound;
            _switchEvents.OnDisabledEvent += PlaySound;
        }

        private void OnDisable()
        {
            _switchEvents.OnEnabledEvent -= PlaySound;
            _switchEvents.OnDisabledEvent -= PlaySound;
        }

        private void Awake()
        {
            _switchEvents = GetComponent<ISwitchEvent>();
            _audioSource = GetComponent<AudioSource>();
        }
        #endregion

        private void PlaySound()
        {
            _audioSource.clip = _sounds[UnityEngine.Random.Range(0, _sounds.Length)];
            _audioSource.Play();
        }
    }
}
