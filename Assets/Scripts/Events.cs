using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
    // Start is called before the first frame update
   public void NeustartGame()
    {
        SceneManager.LoadScene("Level1");
        
    }

    public void SchließenGame()
    {
        SceneManager.LoadScene("StartScreen");
    }
   
}
