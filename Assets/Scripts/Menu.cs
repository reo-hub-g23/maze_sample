using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    [SerializeField] private Button pauseButton;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button retryButton;


    private void Start()
    {
        pausePanel.SetActive(false); // ポーズのパネルは初期状態では非表示

        pauseButton.onClick.AddListener(Pause);
        resumeButton.onClick.AddListener(Resume);
        retryButton.onClick.AddListener(Retry);
       
    }

    private void Pause()
    {
        Time.timeScale = 0; // Time.timeScaleで時間の流れの速さを決める。0だと時間が停止する
        pausePanel.SetActive(true);
    }

    private void Resume()
    {
        Time.timeScale = 1; 
        pausePanel.SetActive(false);
    }
    private void Retry(){
        Time.timeScale = 1; 
        SceneManager.LoadScene("first");
    }
}

    