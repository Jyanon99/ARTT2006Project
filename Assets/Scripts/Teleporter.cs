using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // 指定目標位置的GameObject
    public GameObject target;

    // 當其他GameObject進入這個trigger collider時觸發
    void OnTriggerEnter(Collider other)
    {
        // 檢查碰撞的物件是否是玩家
        if (other.gameObject.CompareTag("Player"))
        {
            // 將玩家的位置設定為目標GameObject的位置
            other.gameObject.transform.position = target.transform.position;
            Debug.Log("tp player");
        }
    }
}
