using UnityEngine;

public class UserData : MonoBehaviour
{
    public string playerName;
    public static UserData Instance;

    private void Awake() {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    
    
}
