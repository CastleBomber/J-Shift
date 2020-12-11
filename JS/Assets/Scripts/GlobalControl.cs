using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
	public HitPoints HP;
	//public float Coins;

    public static GlobalControl Instance;

	void Awake()
	{
		if (Instance == null)
		{
			DontDestroyOnLoad(gameObject);
			Instance = this;
			//Instance.HP = 10;
		}
		else if (Instance != this)
		{
			Destroy(gameObject);
		}
	}
}
