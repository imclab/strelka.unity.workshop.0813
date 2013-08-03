using UnityEngine;

public class Levels04 : MonoBehaviour
{
    public int Level = 1;

    private static Levels04 instance;
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
            else
            {
                var player = GameObject.Find("Player");
                foreach (Transform enemy in enemies.transform)
                {
                    if (enemy.position.y - enemy.collider.bounds.extents.y <= player.transform.position.y + player.collider.bounds.extents.y)
                    {
                        Application.LoadLevel("Game Over");
                    }
                }
            }
        } else
        {
            if (Input.GetKeyUp(KeyCode.Return))
            {
                if (Application.loadedLevelName == "You Win") Level++;
                Application.LoadLevel(currentLevelName);
            }
        }
    }
}