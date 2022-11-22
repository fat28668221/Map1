using UnityEngine;

namespace Justin
{
    /// <summary>
    /// 玩家結束管理:死亡或通關
    /// </summary>
    public class PlayerFinal : MonoBehaviour
    {
        private void OnDestroy()
        {
            FinalManger.instance.GameOver("挑戰失敗!");
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            FinalManger.instance.GameOver("遊戲通過");
        }
    }
}

