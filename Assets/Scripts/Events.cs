using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
    // Start is called before the first frame update
   public void NeustartGame()
    {
        SceneManager.LoadScene(0);
        
    }

    public void Schlie�enGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
