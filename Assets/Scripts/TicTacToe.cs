using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToe : MonoBehaviour
{
    public Sprite O, X;
    private SpriteRenderer spriteR;
    private void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        spriteR.sprite = O;
    }
    private void OnMouseDown()
    {
        if(spriteR.sprite == O)
        {
        spriteR.sprite = X;
            spriteR.color = new Color(1, 0, 0, 1);
        }
        else
        {
            spriteR.sprite = O;
            spriteR.color = new Color(255, 0, 0, 1);
        }
    }
}
