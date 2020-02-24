using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light[] lights;
    public ParticleSystem[] particles;
    public bool isOn;
    // Start is called before the first frame update

    private void Awake()
    {
        lights = FindObjectsOfType<Light>();
    }
    void Start()
    {   
        foreach(Light light in lights) light.enabled = isOn;
        foreach (ParticleSystem particle in particles)
        {
            if (isOn) particle.Play();
            else particle.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
       // isOn = !isOn;
        foreach (Light light in lights) light.enabled = !light.enabled;
        foreach (ParticleSystem particle in particles)
        {
            if (particle.isPlaying) particle.Stop();
            else particle.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print("trigger" + other.gameObject.name);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("collision" + collision.gameObject.name);
    }
}
