using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCollider : MonoBehaviour
{
    public Sprite newSprite;
    [SerializeField]
    private static int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        BirdController bird =collision.gameObject.GetComponent<BirdController>();// we are takling the reference of the bird/
        if (bird != null || collision.gameObject.tag == "Crate")//if only if when my bird is only Hitting the monster in that time only my monster will inactive or destroy.
        {
            MonsterDeath();
            print(gameObject.name);
            //Destroy(gameObject);
            
        }
    }

    private void MonsterDeath()
    {
        GetComponent<SpriteRenderer>().sprite = newSprite;
        gameObject.SetActive(false);
        score = score + 10;
        print("Score :" + score);
    }
}

// I want to create a two level .. in next level more monster more crates
//check for preventing multiple deaths
// level 2: more complexity but when the collision happens we print the score. with collision happens;
//Each level separated enviroment