using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControll : MonoBehaviour
{
    [SerializeField] string _nextLevelName;

    Monter[] _monsters;
    


    // Start is called before the first frame update
    void OnEnable()
    {
        _monsters = FindObjectsOfType<Monter>();
    }

/*    private Monter[] FindObjectsOfType()
    {
        return FindObjectsOfType<Monter>();
    }
*/
    // Update is called once per frame
    void Update()
    {
        if (MonsterAreAllDead())
            GoToNextLevel();
    }

     void GoToNextLevel()
    {
        Debug.Log("go to level " + _nextLevelName);
        SceneManager.LoadScene(_nextLevelName);
    }

      bool MonsterAreAllDead()
    {
        foreach (var monster in _monsters)
        {
            if(monster.gameObject.activeSelf)
            {
                return false;
            }

        }
        return true;
    }
}
