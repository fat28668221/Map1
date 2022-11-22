
using UnityEngine;

namespace Justin
{
    /// <summary>
    /// 敵人發射
    /// </summary>
    public class EnemyFireSystem : FireSystemBase
    {
        [SerializeField, Header("生成間隔"), Range(0, 3)]
        private float interval = 1.5f;

            private void Awake()
        {
            //呼叫自訂方法
            //SpawnBullet();

            //延遲
            
        }

        private void OnBecameVisible()
        {
            InvokeRepeating("SpawnBullet", 0, interval);
        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}




