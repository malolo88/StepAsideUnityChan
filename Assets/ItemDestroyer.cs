using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんと壁の距離
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんと壁の位置(z座標)の差を求める
        this.distance = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置に合わせて壁の位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - distance);
    }

    //オブジェクトと接触した場合にアイテムを破棄
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "TrafficConeTag" || other.gameObject.tag == "CoinTag" || other.gameObject.tag == "CarTag")
        {
            Destroy(other.gameObject);
        }
        
    }
}
