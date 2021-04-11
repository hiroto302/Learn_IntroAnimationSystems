using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemPlayer : MonoBehaviour
{
    public ParticleSystem particles;

    void PlayParticles()
    {
        // セットしている Particle の実行
        particles.Play();
    }
}
