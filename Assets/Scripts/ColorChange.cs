using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColorChange : MonoBehaviour, IPointerClickHandler{

    private Renderer rend;

    public void OnPointerClick(PointerEventData eventData) {

        ChangeTheColor();
    }

    public void ChangeTheColor() {

        rend = GetComponent<Renderer>();

        rend.material.color = Color.blue;
    }

}
