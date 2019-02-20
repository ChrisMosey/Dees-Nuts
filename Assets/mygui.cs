using System.Collections;
using UnityEngine;
 
public class mygui : MonoBehaviour{

    public Texture2D acornImage;
    public PlayerController player;

    void OnGUI(){

        // Acorn Image
        GUI.DrawTexture(new Rect(10, 10, 55, 60), acornImage);

        // Number of Acorns
        GUIStyle guiStyle = new GUIStyle(); //create a new variable
        guiStyle.fontSize = 23; //change the font size
        guiStyle.normal.textColor = Color.white;//change the font size
        guiStyle.alignment = TextAnchor.UpperCenter;

        GUI.Label(new Rect(10, 31, 55, 20), player.getNumAcorns().ToString(), guiStyle);

    }
}
 