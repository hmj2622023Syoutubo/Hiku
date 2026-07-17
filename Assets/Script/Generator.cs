using TMPro;
using UnityEngine;

public class Generator : MonoBehaviour
{
	[SerializeField] GameObject text;
	int timer;
	int dice;
	public static int SCORE;
	public static int score2;
	public void score(int score)
	{
		SCORE += score;
	}

	private void Update()
	{
		text.GetComponent<TextMeshProUGUI>().text = SCORE.ToString("F1");
	}
}
