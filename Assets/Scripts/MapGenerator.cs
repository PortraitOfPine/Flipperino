using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapGenerator : MonoBehaviour
{
    #region fields
    [SerializeField]
    private GameObject prefab_;
    [SerializeField]
    private float gap_;
    private float prefabSize_;
    private float topEnd_;
    private float bottomEnd_;
    private float timer_;
    #endregion


    // Use this for initialization
    void Start()
    {
        this.topEnd_ = 0.0f;
        this.bottomEnd_ = 8.0f;
        this.timer_ = 4.0f;
        this.prefabSize_ = this.prefab_.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        this.timer_ += Time.deltaTime;
        if (this.timer_ >= 2)
        {
            if (this.topEnd_ > this.bottomEnd_)
            {
                Instantiate(this.prefab_, new Vector3(this.topEnd_ + this.prefabSize_ / 2 + this.gap_, -3, 0), Quaternion.identity);
                this.bottomEnd_ = this.topEnd_ + 5 + this.gap_;
            } else
            {
                Instantiate(this.prefab_, new Vector3(this.bottomEnd_ + this.prefabSize_ / 2 + this.gap_, 3, 0), Quaternion.identity);
                this.topEnd_ = this.bottomEnd_ + 5 + this.gap_;
            }

            this.timer_ = 0.0f;
        }
    }

    void CreatePlatform(Vector3 position)
    {


    }
}
