#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TextMeshProUGUI highScoreText;
    public void Exit() {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #endif
        Application.Quit();
    }
    public void StartGame() {
        SceneManager.LoadScene(1);
    }
    private void Start() {
        inputField.text = UserData.Instance.playerName;
        if (UserData.Instance.highScore != 0)
        {
            highScoreText.text  = $"High Score : {UserData.Instance.playerName} : {UserData.Instance.highScore}";
        }
    }
    public void SetPlayerName() {
        UserData.Instance.SetUserName(inputField.text);
    }
}
