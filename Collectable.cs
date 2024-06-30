using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int myScore = 5;
    bool collected = false;
    string collectibleName = "Coins";
    string collectiblesDescription = "These are some coins";

    [SerializeField]
    private AudioClip collectAudio;

    // Start is called before the first frame update
    void Collected()
    {
        AudioSource.PlayClipAtPoint(collectAudio, transform.position, 1f);
        Debug.Log("I got collected");
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().IncreaseScore(myScore);
            Collected();
        }
    }

    public virtual void CollectableCollected()
    {
        Debug.Log("Collectible collected");
        Collected();
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Something stopped touching me");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Something is still touching me");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something entered the area");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Something left the area");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Something is still touching me");
    }
    void Spawn()
    {

    }
    void Expire()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}



