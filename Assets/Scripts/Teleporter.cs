using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // 指定目標位置的GameObject
    public GameObject target;

    public AudioSource　ringSource;

    public AudioClip ringClip;

    // 當其他GameObject進入這個trigger collider時觸發
    void OnTriggerEnter(Collider other)
    {
        // 檢查碰撞的物件是否是玩家
        if (other.gameObject.CompareTag("Player"))
        {
            // 將玩家的位置設定為目標GameObject的位置
            other.gameObject.transform.position = target.transform.position;
            //other.gameObject.transform.rotation = transform.rotation;
            Debug.Log("tp player");
            ringSource.clip = ringClip;
            ringSource.Play();
        }
    }
}
