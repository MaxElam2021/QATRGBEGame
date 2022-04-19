using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
	[SerializeField] GameObject dialogue;
	PlayerMovement player;

	bool hasShown = false;

	bool optionOne = true;

    // Start is called before the first frame update
    void Start()
    {
		dialogue.SetActive(false); 
		player = FindObjectOfType<PlayerMovement>();
    }

	void OnTriggerEnter2D(Collider2D other){
		if (hasShown == false) 
		{
			if (other.tag == "Player") 
			{
				dialogue.SetActive(true);
				player.DialogEnter();
				hasShown = true;
			}
		}
	}	

    // Update is called once per frame
    void Update()
    {

    }
}

