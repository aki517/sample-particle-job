using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// .
/// </summary>
public class SampleParticle1 : MonoBehaviour
{
    ParticleSystem              m_particleSystem;
    ParticleSystem.Particle[]   m_particles;
    List<Vector4>               m_customDataList = new List<Vector4>();

    void Awake()
    {
        m_particleSystem = GetComponent<ParticleSystem>();
    }

    void LateUpdate()
    {
        if( m_particles == null ){
            m_particles = new ParticleSystem.Particle[ m_particleSystem.main.maxParticles ];
        }

        Color color;
        m_particleSystem.GetCustomParticleData( m_customDataList, ParticleSystemCustomData.Custom1 );
        int numAlive = m_particleSystem.GetParticles( m_particles );
        for( int idx=0 ; idx < numAlive ; idx++ )
        {
            color.r = m_customDataList[ idx ].x;
            color.g = m_customDataList[ idx ].y;
            color.b = m_customDataList[ idx ].z;
            color.a = m_customDataList[ idx ].w;
            m_particles[ idx ].startColor = color;
        }
        m_particleSystem.SetParticles( m_particles );
    }

}   // End of class SampleParticle1.
