using UnityEngine;

namespace Justin
{
    /// <summary>
    /// ���a�����޲z:���`�γq��
    /// </summary>
    public class PlayerFinal : MonoBehaviour
    {
        private void OnDestroy()
        {
            FinalManger.instance.GameOver("�D�ԥ���!");
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            FinalManger.instance.GameOver("�C���q�L");
        }
    }
}

