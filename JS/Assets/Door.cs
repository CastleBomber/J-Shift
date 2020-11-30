using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    GameManager gm;
	[SerializeField] GameObject DoorType;
	public int nextLevel;
	int stateOfDoor = 1;

	private void OnTriggerEnter2D(Collider2D col)
	{
			gm.LoadNextLevel(nextLevel);
	}

	private void Start()
	{
		gm = FindObjectOfType<GameManager>();
	}

}
