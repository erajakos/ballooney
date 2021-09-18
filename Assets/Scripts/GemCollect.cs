using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour
{
	private AudioSource collectAudio;

    private void Awake()
    {
		collectAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Airship")
		{
			GetComponent<Collider>().enabled = false;
			Collect();
		}
	}

	public void Collect()
	{
		collectAudio.Play();
		FindObjectOfType<GameManager>().CollectGem();
		GetComponent<MeshRenderer>().enabled = false;
		Destroy(gameObject, 5f);
		GetComponent<ParticleSystem>().Play();
	}
}
