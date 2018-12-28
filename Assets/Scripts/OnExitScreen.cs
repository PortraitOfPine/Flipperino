using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnExitScreen : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
