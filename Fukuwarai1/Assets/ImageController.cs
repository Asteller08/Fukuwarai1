using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    // 初期化関数
    void Start()
    {
        // オブジェクトの取得
        GameObject image_object = GameObject.Find("Image");
        // コンポーネントの取得
        Image image_component = image_object.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
