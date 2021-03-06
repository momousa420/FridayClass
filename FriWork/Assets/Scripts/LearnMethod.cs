using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 非靜態方法
/// </summary>
public class LearnMethod : MonoBehaviour
{
    //非靜態方法使用方式
    //1.定義一個欄位，用於儲存實體資料
    //2.欄位資料類型必須與想存取的非靜態屬性類型相同
    //3.欄位必須存放實體物件 (將物件拖曳至欄位內)

    public Transform traObject;
    public Rigidbody2D rig;

    private void Start()
    {
        //非靜態方法
        //呼叫方法
        //語法：欄位名稱.非靜態方法名稱(對應的引數);
        traObject.Rotate(0, 0, 10);

        
    }

    //更新事件：一秒執行約 60 次     60FPS
    private void Update()
    {
        traObject.Rotate(0, 0, 10);
        rig.AddForce(new Vector2(0, 30));

    }

}
