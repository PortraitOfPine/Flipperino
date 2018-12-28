using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    #region fields
    [SerializeField]
    private float speed_;
    [SerializeField]
    private bool canOnlyFlipOnPlatform_;
    private Rigidbody2D rigidbody_;
    private bool isFlipped_;
    private bool onGround_;
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
        }
        else
        {
            this.rigidbody_.velocity = new Vector2(3, -3);
        }
    }

    // Flip
    void Flip()
    {
        // Flip the gravity
        // XXX: Not the most readable loop
        if (!this.canOnlyFlipOnPlatform_)
        {
            this.isFlipped_ = !this.isFlipped_;
        } else if (this.onGround_)
        {
            this.isFlipped_ = !this.isFlipped_;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // XXX: If we add new items, we'll have to make sure the collision was
        //      with a platform
        this.onGround_ = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        this.onGround_ = false;
    }

}
