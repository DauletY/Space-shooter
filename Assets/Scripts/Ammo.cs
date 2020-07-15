
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ammo : Game {
    public GameObject mag = null;
    public GameObject explostion = null;
    public override void Start_Game() {

    }
    public override void Build_Game() {

    }
    public override void Trigger(Collider2D other) {
        Stone rb = other.GetComponent<Stone>(); 
        if(rb.tag == "Stone") {
            GameController.Score();
            // mag
            if (GameController.score <= 6) {
                rb.StoneDown();
                //Debug.Log(GameController.score);
            } 
            else if(GameController.score <= 12) {
                Mag();
            }
            else if(GameController.score == 15) {
                Debug.Log(" *** You win *** " + GameController.score);
                StartCoroutine(GameController.Instance.PlaneRepate());
            }else {
            }
            GameObject gO = Instantiate(explostion, rb.transform.position, Quaternion.identity);
            SpriteRenderer thisRen = gO.GetComponent<SpriteRenderer>();
            Destroy(this.gameObject);
            Destroy(thisRen.gameObject,0.2f);
            Destroy(other.gameObject , 0.1f);
        }
    }
    void Mag() {
        GameObject[] mags = new GameObject[2];
        for(int i = 0; i < 2; i++) {
            //Returns a random point inside a circle with radius 1
            Vector2 v2 = new Vector2(Random.Range(-Random.onUnitSphere.x * 5f,
                                        Random.onUnitSphere.x * 5f)  , Vector2.up.y*5f);
            mags[i] =  Instantiate(mag, v2, Quaternion.identity);
        }
    }
}