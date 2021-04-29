using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(ParticleSystem))]

public class Particle : MonoBehaviour
{

    ParticleSystem.Particle[] Particles;

    ParticleSystem particleSytem;

    public Vector3 PartcileVelocity;

    int NumAlive;
    bool ItRan;


    private void LateUpdate()
    {


        InitializelIfNeeded();
        particleSytem = GetComponent<ParticleSystem>();
        ParticleSystem.EmitParams emitOverride = new ParticleSystem.EmitParams();
        particleSytem.SetParticles(Particles, NumAlive);
        particleSytem.Emit(emitOverride, 5000);
        NumAlive = particleSytem.GetParticles(Particles);

        if(ItRan == false)
        {
            Loop();


        }


    }




    private void Loop()
    {


        for (int i = 0; i < Particles.Length; i++)
        {
            Particles[i].position = new Vector3(Random.Range(-4000f, 4000f), Random.Range(-2000f, 2000f), Random.Range(1000f, 4000f));
            Particles[i].velocity = PartcileVelocity;

        }
        ItRan = true;

    }

    void InitializelIfNeeded()
    {



        if (particleSytem == null)
            particleSytem = GetComponent<ParticleSystem>();

        if (Particles == null || Particles.Length < particleSytem.main.maxParticles)
            Particles = new ParticleSystem.Particle[particleSytem.main.maxParticles];

    }

}
