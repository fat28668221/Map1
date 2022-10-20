
using UnityEngine;

namespace Justin
{
    /// <summary>
    /// ������� 2D �Ҧ�
    /// </summary>
    public class AirPlaneController2D : MonoBehaviour
    {
        [Header("���ʳt��")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 30.5f;
        [SerializeField, Range(0,10)]
        private float speedHorizontal = 4f;
        [Header("�Ϥ�")]
        [SerializeField]
        private Sprite pictureUP;
        [SerializeField]
        private Sprite pictureMiddle;
        [SerializeField]
        private Sprite pictureDown;

    }
}



