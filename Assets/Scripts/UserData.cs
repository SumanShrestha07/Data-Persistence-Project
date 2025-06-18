using System.IO;
using UnityEngine;

public class UserData : MonoBehaviour
{
    public string playerName;
    public static UserData Instance;
    public int highScore;
    
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
        ReadHighScore();
    }
    private void ReadHighScore() {
        var path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Debug.Log(json);
            HighScore data = JsonUtility.FromJson<HighScore>(json);
            playerName = data.name;
            highScore = data.score;
        }
    }
    public void SaveHighScore() {
        HighScore score = new HighScore()
        {
            name = playerName,
            score = highScore
        };
        var json = JsonUtility.ToJson(score);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void SetUserName(string username) {
        playerName = username;
    }

}
[System.Serializable]
public class HighScore
{
    public string name;
    public int score;
}

[System.Serializable]
public class SaveUserName
{
    public string username;
}