using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToe : MonoBehaviour
{
    Color[] colorlist = { Color.yellow, Color.green, Color.red, Color.blue};
    private GameObject thing;
    private SpriteRenderer sprite;
    private void Start()
    {
        sprite = thing.GetComponent<SpriteRenderer>();
        thing = GameObject.Find("Color");
        colorChange();
    }
    private void OnMouseDown()
    {
        colorChange();
    }
    void colorChange()
    {
        sprite.color = colorlist[Random.Range(0, colorlist.Length)];
    }
}
