using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip playerHurtSound, penaltySound;

    private void OnEnable()
    {
        GameEvents.TakeDamage += PlayHurtSound;
        GameEvents.RacePenalty += PlayPenaltySound; 
    }
    private void OnDisable()
    {
        GameEvents.TakeDamage -= PlayHurtSound;
        GameEvents.RacePenalty -= PlayPenaltySound;
    }
    private void PlayPenaltySound()
    {
        source.PlayOneShot(penaltySound);
    }
    private void PlayHurtSound()
    {
        source.PlayOneShot(playerHurtSound);
    }
   
}
