using UnityEngine;

public class VARManager : MonoBehaviour
{
    public bool isReviewing = false;

    void Update()
    {
        if (isReviewing)
        {
            ReviewDecision();
        }
    }

    public void StartReview()
    {
        isReviewing = true;
        // Transition to VAR review scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("VARReview");
    }

    void ReviewDecision()
    {
        // Implement VAR decision logic
        // Show replay, make decision, and return to match
    }
}