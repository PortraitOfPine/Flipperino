using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    #region fields
    [SerializeField]
    private GameObject followedTarget_;
    #endregion

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(this.followedTarget_.transform.position.x, 0.0f, -10.0f);
    }
}
