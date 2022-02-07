using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joint_controller : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    public float weight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //        --------------------------------------- MOVE TO Start() -----------------------------------------
        int colorInt = (int) ((1 - this.weight) * 765);
        // Change into White => Red => Black colors
        float R_value = ((float) colorInt) / 255f;
        float GB_value  = 0f;
        if (colorInt > 255)
        {
            GB_value = ((float) ((colorInt - 255) / 2))/255f;
            R_value = 1f;
        }
        Color newColor = new Color(R_value, GB_value, GB_value);
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = newColor;
        Rigidbody2D joint_rb = GetComponent<Rigidbody2D>();
        joint_rb.drag = weight * 10;
    }
}
