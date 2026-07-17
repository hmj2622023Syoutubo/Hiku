using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
	private void Update()
	{
		transform.Translate(0, 0, 0.05f);
		if (Keyboard.current.aKey.isPressed && transform.position.x >= -0.5)
		{
			transform.Translate(-0.01f, 0, 0);
		}
		if (Keyboard.current.dKey.isPressed && transform.position.x <= 3.6)
		{
			transform.Translate(0.01f, 0, 0);
		}
	}
}
