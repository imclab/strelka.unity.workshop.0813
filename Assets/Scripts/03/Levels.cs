using UnityEngine;

public class Levels : MonoBehaviour
{
    public int Level = 1;

    private static Levels instance;
    private string currentLevelName;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else
        {
            if (this != instance)
            {
                Destroy(gameObject);
                return;
            }
        }

        DontDestroyOnLoad(gameObject);

        if (currentLevelName == null) currentLevelName = Application.loadedLevelName;
    }

    private void Update()
    {
        var enemies = GameObject.Find("Enemies");
        if (enemies != null)
        {
            if (enemies.transform.childCount == 0)
            {
                Application.LoadLevel("You Win");
            }
        } else
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                if (Application.loadedLevelName == "You Win") Level++;
                Application.LoadLevel(currentLevelName);
            }
        }
    }
}