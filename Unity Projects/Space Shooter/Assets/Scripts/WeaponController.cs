using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

	public Transform shotSpawn;
	public GameObject shot;
	public float fireRate;
	public float delay;

	private AudioSource audioSource;

	void Start () {
		audioSource = GetComponent<AudioSource> ();
		InvokeRepeating ("Fire",delay,fireRate);

	}

	void Fire()
	{
		Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
	}


}
