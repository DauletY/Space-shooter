
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ammo : Game {
    public override void Start_Game() {}
    public override void Build_Game() {}
    public override void Trigger(Collider2D other) {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if(rb.tag == "Stone") {
            Destroy(this.gameObject);
            Destroy(other.gameObject , 0.1f);
        }
    }
}