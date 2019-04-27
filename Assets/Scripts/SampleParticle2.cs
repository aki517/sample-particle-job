using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Experimental.ParticleSystemJobs;

/// <summary>
/// .
/// </summary>
public class SampleParticle2 : MonoBehaviour
{
    ParticleSystem  m_particleSystem;
    ParticleJob     m_particleJob;

    void Awake()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        ps.SetJob( new ParticleJob());
    }

    struct ParticleJob : IParticleSystemJob
    {
        public void ProcessParticleSystem( ParticleSystemJobData jobData )
        {
            Color customColor = Color.white;

            var startColors = jobData.startColors;
            var customDatas = jobData.customData1;
            for( int idx=0 ; idx < startColors.Length ; idx++ )
            {
                customColor.r = customDatas.x[ idx ];
                customColor.g = customDatas.y[ idx ];
                customColor.b = customDatas.z[ idx ];
                customColor.a = customDatas.w[ idx ];
                startColors[ idx ] = customColor;
            }
        }
    }
}
