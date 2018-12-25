using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{

    #region fields
    private Rigidbody2D rigidbody_;
    [SerializeField]
    private float speed_;
    private bool isFlipped_;
    #endregion

    // Use this for initialization
    void Start()
    {
        rigidbody_ = this.GetComponent<Rigidbody2D>();
        // FIXME: If there is a colision, the cube could go backward
        this.isFlipped_ = false;
        this.rigidbody_.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.Flip();
        }

        // Apply force
        if (this.isFlipped_)
        {
            this.rigidbody_.velocity = new Vector2(3, 3);
        } else
        {
            this.rigidbody_.velocity = new Vector2(3, -3);
        }
    }

    // Flip
    void Flip()
    {
        // Flip the gravity
        this.isFlipped_ = !this.isFlipped_;
    }
}
