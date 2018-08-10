using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MetaAudioController : MonoBehaviour
{

    public AudioSource loopingSFX;
    public GameObject[] waveSfxPrefabs;
    public GameObject[] explosionSfxPregabs;
    public GameObject[] smallExplosionSfxPregabs;
    public float globalProgressSpeed = 1f, startTimer, t = 0.2f;
    private float realPitch = 1;


    private float globalProgress, pitchFinalValue = 0;

    void Start()
    {

        globalProgress = 0f;

    }

    // Spawn Empty with Sound FX
    public void EmitParticleExplosion(Vector3 pos, bool big)
    {
        if (big == true)
        {
            Instantiate(explosionSfxPregabs[Random.Range(0, explosionSfxPregabs.Length)], pos, transform.rotation);
        }
        else
        {
            Instantiate(smallExplosionSfxPregabs[Random.Range(0, smallExplosionSfxPregabs.Length)], pos, transform.rotation);
        }
    }

    void Update()
    {

        if (globalProgress >= 0f)
        {
            globalProgress -= Time.deltaTime * globalProgressSpeed;
        }

        loopingSFX.volume = globalProgress - 0.1f;

        if (Time.time - startTimer > 0.1f)
        {
            loopingSFX.pitch = 1;
            realPitch = 1;
            t = 0.5f;
        }
    }

    public void ResetLaserProgress()
    {
        globalProgress = 1f;
    }

    public void StartSound()
    {
        Instantiate(waveSfxPrefabs[Random.Range(0, waveSfxPrefabs.Length)], transform.position, transform.rotation);
    }

    public void energyTransmisionSound(float value)
    {
        startTimer = Time.time;

        if (value / 15 > realPitch)
        {
            realPitch -= Time.unscaledDeltaTime / 3;
        }
        else if (value / 15 < realPitch)
        {
            realPitch += Time.unscaledDeltaTime / 3;
        }

        realPitch = Mathf.Clamp(realPitch, 0.5f, 1f);
        loopingSFX.pitch = realPitch;

    }
}
