#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    public void Exit() {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #endif
        Application.Quit();
    }

    public void StartGame() {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName() {
        UserData.Instance.playerName = inputField.text;
    }
}
