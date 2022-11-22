using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace Justin
{
    /// <summary>
    /// 結束管理器
    /// </summary>
    public class FinalManger : MonoBehaviour
    {
        public static FinalManger instance;

        private CanvasGroup groupFinal;

        private TextMeshProUGUI textTitle;
        private Button btnReplay;

        private void Awake()
        {
           groupFinal =  GameObject.Find("結束畫布").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("結束標題").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("重新遊戲").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);
        }
        public void GameOver(string title)
        {
            textTitle.text = title;
            StartCoroutine(FadeIn());
        }

        private IEnumerator FadeIn()
        {
            for(int i = 0; i < 10; i++)
            {
                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.02f);
            }
            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;
        }
        private void Replay()
        {
            SceneManager.LoadScene("開始選單");
        }
    }
}


