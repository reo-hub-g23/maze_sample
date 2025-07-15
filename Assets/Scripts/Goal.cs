using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {    
        if (other.CompareTag("Player")) 
        {
            Debug.Log("ゴールに到達！");
            SceneManager.LoadScene("GoalScene"); 
        }
    }
}
