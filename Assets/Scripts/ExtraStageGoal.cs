using UnityEngine;
using UnityEngine.SceneManagement;

public class ExtraGoalStage : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {    
        if (other.CompareTag("Player")) 
        {
            Debug.Log("[ExtraSatge]ゴールに到達！");
            SceneManager.LoadScene("ExtraGoal"); 
        }
    }
}
