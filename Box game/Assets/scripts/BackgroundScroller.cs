using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{

    public Rigidbody2D _rb2d;
    public BoxCollider2D _bc2d;

   

    

    // Start is called before the first frame update
    void Start()
    {
        _bc2d = GetComponent<BoxCollider2D>();
        _rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
