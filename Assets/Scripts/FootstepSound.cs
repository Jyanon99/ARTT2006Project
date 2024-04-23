using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    // 腳步聲音的AudioSource
    public AudioSource footstepSource;
    // 不同地形的腳步聲音剪輯
    public AudioClip terrainGrassClip;
    public AudioClip terrainRoadClip;
    public AudioClip terrainWoodClip;

    // 上一次播放聲音的地形類型
    private string lastTerrainType;

    // 更新函數中檢查玩家輸入
    void Update()
    {
        // 當玩家按下WASD鍵時
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) ||
            Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            // 從玩家位置向下發射射線
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.down, out hit))
            {

                // 獲取當前地形類型
                string currentTerrainType = hit.collider.tag;

                if (currentTerrainType != lastTerrainType)
                {

                    // 根據地形類型播放對應的腳步聲音
                    switch (hit.collider.tag)
                    {
                        case "grass_ground":
                            footstepSource.clip = terrainGrassClip;
                            Debug.Log("terrainGrassClip Play");
                            footstepSource.enabled = false;
                            break;
                        case "road_ground":
                            footstepSource.clip = terrainRoadClip;
                            Debug.Log("terrainRoadClip Play");
                            footstepSource.enabled = false;
                            break;
                        case "wood_ground":
                            footstepSource.clip = terrainWoodClip;
                            Debug.Log("terrainWoodClip Play");
                            footstepSource.enabled = false;
                            break;
                    }

                }

                // 停止當前播放的聲音並播放新的腳步聲音
                footstepSource.enabled = true;
                lastTerrainType = currentTerrainType; // 更新上一次的地形類型
            }
        }
        else
        {
            footstepSource.enabled = false;
        }
    }
}
