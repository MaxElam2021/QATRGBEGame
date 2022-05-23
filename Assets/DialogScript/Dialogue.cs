using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
	[SerializeField] GameObject dialogue;
	[SerializeField] GameObject dialogueOpt;

	PlayerController player;
	CountdownTimer time;

	bool hasShown = false;

	bool optionOne = true;

	public bool isGoal = false;

    // Start is called before the first frame update
    void Start()
    {
		dialogue.SetActive(false); 

		if (isGoal)
        {
			dialogueOpt.SetActive(false);
        }

		player = FindObjectOfType<PlayerController>();
		time = FindObjectOfType<CountdownTimer>();
    }

	void OnTriggerEnter2D(Collider2D other){
		if (hasShown == false) 
		{
			if (other.tag == "Player")
			{
				if (isGoal == false)
				{
					dialogue.SetActive(true);
				} else
                {
					if (ScoreManager.instance.score >= 10)
                    {
						dialogueOpt.SetActive(true);
                    } else
                    {
						dialogue.SetActive(true);
                    }
                }
                Debug.Log("Works perfectly");
                player.DialogEnter();
				hasShown = true;
				time.shouldCount = false;
			}
		}
	}
	
}

