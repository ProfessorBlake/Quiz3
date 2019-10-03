using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public GameObject BallPrefab;
	public Text BallCountText;
	public int BallCount;

	public void Button_CreateBall()
	{
		Instantiate(BallPrefab, new Vector3(Random.Range(-5f, 5f), 5f, 0f), Quaternion.identity);
		BallCount++;
		BallCountText.text = BallCount.ToString();
	}

	public void Button_ChangeLevel(int level)
	{
		SceneManager.LoadScene(level);
	}
}
