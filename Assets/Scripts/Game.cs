
using UnityEngine;
public abstract class Game : MonoBehaviour
{
    public abstract void  Build_Game();
    public abstract void Start_Game();

    public virtual void Trigger(Collider2D other) {}
    private void Start() {
        Start_Game();
    }
    private void Update() {
        Build_Game();    
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Trigger(other);
    }
}
