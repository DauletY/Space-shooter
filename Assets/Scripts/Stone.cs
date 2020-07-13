using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : Game
{
    public float speedZ;
    public float speed;
    Rigidbody2D r2d;
    public override void Start_Game() {
        r2d = GetComponent<Rigidbody2D>();
    }
    public override void Build_Game() {
        r2d.transform.Rotate(Vector3.back * speedZ);

        if(r2d.position.y <= -9f) {
            Destroy(r2d.gameObject);
        }
    }
    public void StoneDown() {
        r2d.velocity = Vector3.back * speed;
    }
    public override void Trigger(Collider2D other) {
        GameController gameController =  GameObject.FindWithTag("GameController").GetComponent<GameController>();
        if(other.CompareTag("Player")) {
            //--Plane.fuel;
            gameController.Lose(Plane.fuel);
            if(gameController.thisImage.fillAmount == 0f) {
                Destroy(other.gameObject, 0.3f);
                Debug.Log("Player die!");
            }
        }
    }
}
