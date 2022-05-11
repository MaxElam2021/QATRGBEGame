using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public GameObject player;

    public float centerScreen = 216.8f;
    public float minPosition = 164.2f;
    public float maxPosition = 1165f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(centerScreen, Mathf.Clamp(player.transform.position.y, minPosition, maxPosition), -1f);
    }
}
