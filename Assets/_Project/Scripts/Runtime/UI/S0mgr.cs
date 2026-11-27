using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class S0Mgr : MonoBehaviour
{
    public Button btnStart;
    public Button btnExit;
     
    void Start()
    {
        btnStart.onClick.AddListener(OnStartClick);
        btnExit.onClick.AddListener(OnExitClick);
    }
    void Update()
    {
         
    }
     
    private void OnStartClick()
    {
        SceneManager.LoadScene("S1");
    }
     
    private void OnExitClick()
    {
        Application.Quit();
    }
}

