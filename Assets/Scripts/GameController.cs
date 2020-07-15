using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
public class GameController : Game {
    public static GameController Instance;
    public static int score = 0;
    public float time = 1f;
    public static TextMeshPro thisTmP;
    public Image thisImage = null;
    public override void Start_Game() {
        Instance = this;
        thisTmP = GetComponent<TextMeshPro>();
        //thisImage = GetComponent<Image>();
        thisTmP.text = "Score: " + score;
        //if(thisImage != null) 
         //   print("t");
     }
    public override void Build_Game() {

    }
    public static void Score() {
        score++;
        thisTmP.text = "Score: " + score;
    }
    public void Lose(float f) {
        thisImage.fillAmount -= f  * Time.deltaTime;
    }
    public IEnumerator PlaneRepate() {
        SceneManager.LoadScene(SceneManager.GetSceneAt(0).buildIndex);
        score = 0;
        yield return new WaitForSeconds(time);   
    }
}