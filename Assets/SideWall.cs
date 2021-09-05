using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerController player;
    public GameManager gameManager;
    void Start()
    {
    }
    void OnTriggerEnter2D(Collider2D anotherCollider)
    {
        if(anotherCollider.name == "Ball")
        {
            player.incrementScore();
            if(player.Score < gameManager.maxScore)
            {
                anotherCollider.gameObject.SendMessage("RestartGame", 2.0f, SendMessageOptions.RequireReceiver);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
