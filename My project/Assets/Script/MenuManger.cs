using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Justin
{
/// <summary>
/// 選單管理器
/// </summary>
    public class MenuManger : MonoBehaviour
    {
        private Button btnplay;

        private void Awake()
        {
            btnplay = GameObject.Find("開始遊戲").GetComponent<>();
            btnplay.onClick.AddListener(StarGame;
        }
        private void StarGame()
        {
            SceneManager.LoadScene("遊戲場景");
        }
    }
}


