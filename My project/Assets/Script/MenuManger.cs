using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Justin
{
/// <summary>
/// ���޲z��
/// </summary>
    public class MenuManger : MonoBehaviour
    {
        private Button btnplay;

        private void Awake()
        {
            btnplay = GameObject.Find("�}�l�C��").GetComponent<>();
            btnplay.onClick.AddListener(StarGame;
        }
        private void StarGame()
        {
            SceneManager.LoadScene("�C������");
        }
    }
}


