
using UnityEngine;

namespace Justin
{
    /// <summary>
    /// 傷害系統
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        [SerializeField, Header("爆炸欲置物")]
        private GameObject prefabExplosion;
        [Header("受傷與爆炸音效")]
        [SerializeField]
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;

        //碰撞開始事件
        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print("碰撞:" + collision.gameObject);
            //如果 碰到物件 包含敵機 就爆炸
            if(collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                SoundManger.instance.PlaySound(soundHit, new Vector2(0.7f, 0.9f));
                SoundManger.instance.PlaySound(soundExplosion, new Vector2(01.2f, 1.5f));

                //Destroy 刪除
                Destroy(gameObject);
            }
        }

        //碰撞離開
        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }
        //碰撞持續
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }
}

