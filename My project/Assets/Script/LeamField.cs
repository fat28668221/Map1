using UnityEngine;

namespace Justin
{
    /// <summary>
    /// 學習欄位 Field
    /// </summary>
    public class LeamField : MonoBehaviour
    {
        public int enemy = 5;

        public float speed = 3.5F;
        public float jump  = 7.5F;

        public string NamePlayer = "小騎士";

        public bool isPass = false;
        public bool hasWeapon = true;

        [Header("血量")]
        public int hp = 50;
        [Tooltip("玩家遊玩經過的時間")]
        public float time = 10.5f;

        [Range(1, 99)]
        public int level = 10;
        [Range(2f, 10.5f)]
        public float WalkSpeed = 3.5f;

        [SerializeField]
        public int countBoomb = 7;



           

    }
}

