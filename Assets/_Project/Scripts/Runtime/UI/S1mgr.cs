using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class S1Mgr : MonoBehaviour
{
    public Button btnMain;
     
     
    void Start()
    {
        btnMain.onClick.AddListener(OnMainClick);
    }
 
    void Update()
    {
         
    }
     
    private void OnMainClick()
    {
        SceneManager.LoadScene("S0");
    }
}
