using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyVessel : MonoBehaviour
{

    [SerializeField] private GameObject vessel;
    private AudioSource pourOutSound;

    private void Start()
    {
        pourOutSound = GetComponent<AudioSource>();
    }

    public void Interacted()
    {
        vessel.GetComponent<VesselManager>().EmptyVessel();
        pourOutSound.PlayOneShot(pourOutSound.clip, 1);
    }

}
