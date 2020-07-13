
using UnityEngine;
public class Plane : Game {
    
    public static float fuel = 1.0f;
    public float speed; 
    public float speedAmmo;
    public GameObject AmmoPrefab = null;
    public Transform AmmoPosition = null;
    private Rigidbody2D Rb2d = null;
    public override void Start_Game() {
        Rb2d = this.GetComponent<Rigidbody2D>();
    }
    public override void Build_Game() {
        Move(speed);
        Shot();
    }
    private void Shot() {
        float newAmmo = speedAmmo;
        if (Input.GetMouseButtonDown(0)) {
            GameObject ob = Instantiate(AmmoPrefab, AmmoPosition.position,Quaternion.identity);
            Rigidbody2D rb = ob.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
            rb.velocity = Vector2.up * newAmmo;
            Destroy(rb.gameObject, 1f); // for ammo
        }
    }
    private float Move(float hSp) {
        float x = Input.GetAxis("Horizontal") * hSp;
        Vector2 v2 = new Vector2(x, 0f);
        Rb2d.velocity = v2;
        if (Rb2d.transform.position.x >= 6.02f) {
            Rb2d.transform.position = new Vector2(-6.02f, transform.position.y);
        }
        else if (Rb2d.transform.position.x <= -6.02f) {
            Rb2d.transform.position = new Vector2(6.02f, transform.position.y);
        }
        return x;
    }
    public override void Trigger(Collider2D other) {
    }
}