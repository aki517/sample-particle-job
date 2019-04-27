using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// .
/// </summary>
public class SampleApp : MonoBehaviour
{
    [SerializeField] GameObject m_particle1 = null;
    [SerializeField] GameObject m_particle2 = null;

    void Awake()
    {
        Application.targetFrameRate = 60;
        m_particle1.SetActive( false );
        m_particle2.SetActive( false );
    }

    void OnGUI()
    {
        GUILayout.Label( "FPS:" + ( int )(1.0f / Time.deltaTime) );

        var layout = GUILayout.Height( Screen.height * 0.1f );
        if( GUILayout.Button( "Particle1", layout )){
            m_particle1.SetActive( true );
            m_particle2.SetActive( false );
        }else if( GUILayout.Button( "Particle2", layout )){
            m_particle1.SetActive( false );
            m_particle2.SetActive( true );
        }
    }

}   // End of class SampleApp.
