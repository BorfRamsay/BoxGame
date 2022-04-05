using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    private Rigidbody2D _rb2d;
   

    private bool _isGrounded = false;
    [SerializeField] private List<Transform> _groundCheckPoints = new List<Transform>();

    public float moveSpeed;



    private void Awake()
    {

        _rb2d = transform.GetComponent<Rigidbody2D>();
        
    }


    private void Update()
    {   //Jump
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rb2d.AddForce(new Vector2(0.0f, 10.0f), ForceMode2D.Impulse);

        }

        //endless running 
        _rb2d.velocity = new Vector2(moveSpeed, _rb2d.velocity.y);



        //Box rotation
        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.eulerAngles = new Vector3(0, 0, 90);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

    private void FixedUpdate()
    {
        _isGrounded = CheckGrounded();
    }



    private bool CheckGrounded()
    {
        _isGrounded = false;

        for (int i = 0; i < _groundCheckPoints.Count; i++)
        {
            RaycastHit2D hit2D = Physics2D.CircleCast(
                _groundCheckPoints[i].position, 0.05f, Vector2.down, 0.05f);

            if (hit2D.collider != null)
            {
                if (hit2D.collider.CompareTag("Ground"))
                {
                    return true;
                }
            }
        }
        return false;
    }


    

  
    

}
