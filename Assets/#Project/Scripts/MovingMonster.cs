using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMonster : Monster
{
    public Vector2 speed = Vector2.zero;

    private SpriteRenderer spriteRenderer;

    public float hitRange;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    virtual protected void Update()
    {
        //orientation de l'image

        Vector2 start;
        Vector2 direction;
        
        

        if (speed.x < 0) {
            spriteRenderer.flipX = true;
            start = (Vector2)transform.position + Vector2.left * 0.51f;
            direction = Vector2.left;
        }
        else {
            spriteRenderer.flipX = false;
            start = (Vector2)transform.position + Vector2.right * 0.51f;
            direction = Vector2.right;
        }
        
        Debug.DrawRay(start, direction * hitRange, Color.magenta); //permet de voir ce qu'il y a devant nous. On part de la position et on on va vers la droite
        RaycastHit2D hit = Physics2D.Raycast(start, direction, hitRange);
        
        
        if(hit.collider != null) {
            speed.x *= -1;
        }
        //deplacement
        Vector2 deplacement = speed * Time.deltaTime; //temps qu'il s'est passé entre deux frame
        transform.position += (Vector3)deplacement; //Même en 2D position = Vector3. On caste deplacement en Vector3
        //spriteRenderer.flipx = (speed.x < 0);
    }
}
