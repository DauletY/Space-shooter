
using UnityEngine;
using System.Collections;
public class Spawn : Game 
{
    public GameObject[] getGameObject;
    public float t1, t2;
    public GameObject stone;
    public override void Start_Game() {
        StartCoroutine(Repate());
    }
    public override void Build_Game() {
        
    }   
    private IEnumerator Repate() {
        yield return new WaitForSeconds(t1);
        while (true) {
            float x = Random.Range(-4.2f,4.2f);
            float gO = Random.Range(0,getGameObject.Length);
            Instantiate(stone, new Vector2(x, getGameObject[(int)gO].gameObject.transform.position.y), Quaternion.identity);
            yield return new WaitForSeconds(t2);
        }
    }
}