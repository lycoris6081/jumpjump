
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel: MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    LoadNextLevel();
                }
            }
        }
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
    }
}

