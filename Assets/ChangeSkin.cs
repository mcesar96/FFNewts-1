using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSkin : MonoBehaviour{

	public Sprite[] sprite;
	//the newt on the left is the button
    public Button button;

	public Sprite[] skins1;
	public Sprite[] skins2;
	public Sprite[] skins3;
	public Sprite[] skins4;

	//frames per second = 10
	int fps = 10;
	//count starts at 2 since starting at 0 causes repetition of skins
    int count = 2;

    void Awake() {
        /*Look within the Resources folder for the file "newt_skins" 
        and retrieve all items of type Sprite + store in sprite array*/
        sprite = Resources.LoadAll<Sprite>("newt_skins");

		//store all sprites that makes up their color skin animation in their own array
		skins1 = Resources.LoadAll<Sprite>("red_skins");
		skins2 = Resources.LoadAll<Sprite>("yellow_skins");
		skins3 = Resources.LoadAll<Sprite>("blue_skins");
		skins4 = Resources.LoadAll<Sprite>("green_skins");
    }

	void Update(){
		//index of skin is dependent on how much time has passed 
		//speed depends on fps
		//each skin array has the same Length so arbitrarily, skin1.Length is chosen
		int index = (int) (Time.time * fps) % skins1.Length;
		

		if(count == 2){ //cycle through red skins
			button.image.sprite = skins1[index];
		}
		else if(count == 3){ //cycle through yellow skins
			button.image.sprite = skins2[index];
		}
		else if(count == 0){ //cycle through blue skins
			button.image.sprite = skins3[index];
		}
		else if(count == 1){ //cycle through green skins
			button.image.sprite = skins4[index];
		}
	}

	//when the newt is clicked, this is called 
    public void On_Click_Button() {
		/*increment count and reset when it reaches four*/
        count++; 

        if (count == sprite.Length)
            count = 0;

        //change the sprite image on the button to the sprite located in count index
        button.image.sprite = sprite[count];

		//cycle through animation depending if count is 0, 1, 2, or 3
		Update();
    }
}
