using UnityEngine;

namespace Justin
{
    /// <summary>
    /// �ǲ���� Field
    /// </summary>
    public class LeamField : MonoBehaviour
    {
        public int enemy = 5;

        public float speed = 3.5F;
        public float jump  = 7.5F;

        public string NamePlayer = "�p�M�h";

        public bool isPass = false;
        public bool hasWeapon = true;

        [Header("��q")]
        public int hp = 50;
        [Tooltip("���a�C���g�L���ɶ�")]
        public float time = 10.5f;

        [Range(1, 99)]
        public int level = 10;
        [Range(2f, 10.5f)]
        public float WalkSpeed = 3.5f;

        [SerializeField]
        public int countBoomb = 7;



           

    }
}

