using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class GameController : Game {
    
    public static int score = 0;
    public static TextMeshPro thisTmP;
    public Image thisImage = null;
    public override void Start_Game() {
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
}