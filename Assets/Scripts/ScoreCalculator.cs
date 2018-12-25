using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{

    #region fields
    [SerializeField]
    private Text textScore_;
    private int score_;
    #endregion

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.score_ += 1;
        this.textScore_.text = this.score_.ToString();
    }
}
