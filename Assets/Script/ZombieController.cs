using UnityEngine;

public class ZombieController : MonoBehaviour
{
	[SerializeField]float Speed = 0.01f;
	[SerializeField] AudioClip SE;
	[SerializeField] GameObject Ster;
	[SerializeField] GameObject generator;
	Animator animator;
	AudioSource aud;
	float upSpeed = 0;
	int timer;
	bool se;
	private void Start()
	{
		animator = GetComponent<Animator>();
	}
	void Update()
	{
		GameObject item;
		transform.Translate(0, upSpeed, Speed);
		if (transform.position.y >= 30)
		{
			timer++;
			Speed = 0;
			upSpeed = 0;
			if (se == false)
			{
				item = Instantiate(Ster);
				item.transform.position = transform.position;
				aud = GetComponent<AudioSource>();
				this.aud.PlayOneShot(SE);
				se = true;
			}
			if (timer > 180)
			{
				Destroy(gameObject);
			}
			if(transform.position.z >= 400)
			{
				Speed = 0.03f;
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("atatta");
		Speed = -0.2f;
		upSpeed = 0.09f;
		animator.SetBool("down", true);
	}
}
