using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public string playerName;
    [SerializeField] private InputField nameHolder;

    private void Update()
    {
        playerName = nameHolder.text;
    }
    private void Awake()
    {
        if (Instance != null)
        {
            return;
        }
        Instance = this;
        DontDestroyOnLoad(Instance);
    }
    //Start The Game
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    //Hold The Name

}
