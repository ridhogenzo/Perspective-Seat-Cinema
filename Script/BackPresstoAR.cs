using UnityEngine;
using System.Collections;

public class BackPresstoAR : MonoBehaviour
{


	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
			Application.LoadLevel("TRAILER");
	}
}