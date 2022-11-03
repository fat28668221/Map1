
using UnityEngine;

namespace Justin
{
    /// <summary>
    /// 玩家發射
    /// </summary>
    public class PlayerFireSystem : FireSystemBase
    {
        //偵測玩家行為
        private void Update()
        {
            //玩家按空白建 生成子彈
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }
    }
}


