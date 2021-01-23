using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var size_x = (GetComponent<BoxCollider2D>().size.x) / 2; //各パーツの横幅(当たり判定のため半分に)
        var size_y = (GetComponent<BoxCollider2D>().size.y) / 2; //各パーツの高さ(当たり判定のため半分に)
        Vector2 pos = transform.position;//現在地取得
        //移動制限
        pos.x = Mathf.Clamp(pos.x, -5.0f+size_x, 5.0f-size_x); //カメラに写ってる範囲x軸-5.0～5.0(だいたい)
        pos.y = Mathf.Clamp(pos.y, -3.0f+size_y, 3.0f-size_y); //カメラに写ってる範囲y軸-3.0～3.0(だいたい)
        transform.position = pos;
    }
}
