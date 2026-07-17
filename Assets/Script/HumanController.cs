using UnityEngine;
using UnityEngine.SceneManagement;

public class HumanController : MonoBehaviour
{
	[SerializeField] float Speed = 0.01f;
	float upSpeed = 0;
	int timer;
	void Update()
	{
		timer++;
		transform.Translate(0, upSpeed, Speed);
		if (transform.position.y >= 30)
		{
			Destroy(gameObject);
		}
		if(timer > 2000)
		{
			Destroy(gameObject);
		}
		if(transform.position.z >= 400)
		{
			Speed = 0.05f;
		}
		if(transform.position.z >= 700)
		{
			Speed = 0.08f;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("atatta");
		Speed = -0.1f;
		upSpeed = 0.03f;
		SceneManager.LoadScene("GAMEOVER");
	}
}
