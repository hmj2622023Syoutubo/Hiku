using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Carcontroller : MonoBehaviour
{
	[SerializeField] GameObject zombie;
	[SerializeField] GameObject zombienormal;
	[SerializeField] GameObject human;
	[SerializeField] GameObject generator;
	[SerializeField] AudioClip BGM;
	AudioSource aud;
	int timer;
	int dice;
	float x;
	float y;
	float z;
	private void Start()
	{
		aud = GetComponent<AudioSource>();
		this.aud.PlayOneShot(BGM);
	}
	void Update()
    {
		timer++;
		GameObject item;
		transform.Translate(0, 0, 0.05f);
        if(Keyboard.current.aKey.isPressed && transform.position.x >= -0.5)
		{
			transform.Translate(-0.01f, 0, 0);
		}
        if(Keyboard.current.dKey.isPressed && transform.position.x <= 3.6)
		{
			transform.Translate(0.01f, 0, 0);
		}
		if (timer % 300 == 0)
		{
			dice = Random.Range(0, 3);
			x = Random.Range(-0.5f, 3.6f);
			y = -0.25f;
			z = transform.position.z + 100;
			if (dice == 0)
			{
				item = Instantiate(zombienormal);
				item.transform.position = new Vector3(x, y, z);
			}
			if(dice == 1)
			{
				item = Instantiate(human);
				item.transform.position = new Vector3(x, y, z);
			}
			if (dice == 2 && transform.position.z >= 200)
			{
				item = Instantiate(zombie);
				item.transform.position = new Vector3(x, y, z);
			}
			if(transform.position.z >= 740)
			{
				SceneManager.LoadScene("CLEAR");
			}
		}
    }
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("zombie"))
		{
			generator.GetComponent<Generator>().score(100);
		}
		if (other.gameObject.CompareTag("strongzombie"))
		{
			generator.GetComponent<Generator>().score(300);
		}
		if(other.gameObject.CompareTag("tree"))
		{
			generator.GetComponent<Generator>().score(-100);
		}
	}
}
