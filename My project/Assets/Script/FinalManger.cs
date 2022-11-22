using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace Justin
{
    /// <summary>
    /// �����޲z��
    /// </summary>
    public class FinalManger : MonoBehaviour
    {
        public static FinalManger instance;

        private CanvasGroup groupFinal;

        private TextMeshProUGUI textTitle;
        private Button btnReplay;

        private void Awake()
        {
           groupFinal =  GameObject.Find("�����e��").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("�������D").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("���s�C��").GetComponent<Button>();
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
            SceneManager.LoadScene("�}�l���");
        }
    }
}


