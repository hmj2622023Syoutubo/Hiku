using UnityEngine;

public class Ster : MonoBehaviour
{
	int timer;
	private void Update()
	{
		timer++;
		if(timer > 180)
		{
			Destroy(gameObject);
		}
	}
}
