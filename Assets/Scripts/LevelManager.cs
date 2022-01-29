using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private bool _negative;
    //[SerializeField]
    //private FPS_CustomController _player;

    public bool Negative => _negative;

    RealityObject[] _realityObjects;
    RealityChangeEvent onRealityChange = new RealityChangeEvent();

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    private void Start()
    {
        _realityObjects = FindObjectsOfType<RealityObject>();
        foreach (var obj in _realityObjects)
        {
            onRealityChange.AddListener(obj.OnRealityChange);
        }
        onRealityChange.Invoke(_negative);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _negative = !_negative;
            onRealityChange.Invoke(_negative);
            Debug.Log("Reality change!");
        }
    }


    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if(!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

class RealityChangeEvent : UnityEvent<bool> { }

public enum Reality
{
    Default,
    Negative,
    Both
}