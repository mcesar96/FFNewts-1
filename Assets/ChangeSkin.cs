using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSkin : MonoBehaviour{

    public Sprite[] sprite;
    public Button button;

    int count = 0;

    void Awake() {
        //this code allows component to recognize the sprites
        sprite = Resources.LoadAll<Sprite>("newt_skins");
    }

    public void On_Click_Button() {
        count++;

        if (count == sprite.Length)
            count = 0;

        button.image.sprite = sprite[count];
    }
    
}
