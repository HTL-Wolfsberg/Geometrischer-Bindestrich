using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
    // Start is called before the first frame update
   public void NeustartGame()
    {
        SceneManager.LoadScene(0);
        
    }

    public void SchließenGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
