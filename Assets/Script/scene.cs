using UnityEngine;

public class scene : MonoBehaviour
{
	[SerializeField] AudioClip BGM;
	AudioSource aud;
	private void Start()
	{
		aud = GetComponent<AudioSource>();
		this.aud.PlayOneShot(BGM);
	}
}
