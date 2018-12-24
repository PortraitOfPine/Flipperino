using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{

    #region fields
    private Rigidbody2D rigidbody_;
    [SerializeField]
    private float speed_;
    #endregion

    // Use this for initialization
    void Start()
    {
        rigidbody_ = this.GetComponent<Rigidbody2D>();
        rigidbody_.velocity = new Vector2(this.speed_, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.Flip();
        }
    }

    // Flip
    void Flip()
    {
        // Flip the gravity
        this.rigidbody_.gravityScale = -this.rigidbody_.gravityScale;
    }
}
