using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{

    #region fields
    [SerializeField]
    private Text textScore_;
    [SerializeField]
    private GameObject cube_;
    private float multiplier_;
    #endregion

    // Use this for initialization
    void Start()
    {
        this.multiplier_ = 1.01f;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = this.cube_.transform.position.x;
        this.textScore_.text = Mathf.Ceil(distance * this.multiplier_).ToString();
        this.multiplier_ += 0.01f;
    }
} 