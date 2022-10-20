
using UnityEngine;

namespace Justin
{
    /// <summary>
    /// 飛機控制器 2D 模式
    /// </summary>
    public class AirPlaneController2D : MonoBehaviour
    {
        [Header("移動速度")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 30.5f;
        [SerializeField, Range(0,10)]
        private float speedHorizontal = 4f;
        [Header("圖片")]
        [SerializeField]
        private Sprite pictureUP;
        [SerializeField]
        private Sprite pictureMiddle;
        [SerializeField]
        private Sprite pictureDown;

    }
}



