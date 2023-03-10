using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private ParticleSystem _myParticles;
    // Start is called before the first frame update
    void Start()
    {
        _myParticles = this.gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        _myParticles.Play();
    }
}
