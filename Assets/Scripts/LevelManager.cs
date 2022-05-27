using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Level[] levels;
    public int currentLevel;

    public void StartLevel()
    {
        levels[currentLevel].gameObject.SetActive(true);
    }

    public void StartNextLevel()
    {

    }

    public void EndLevel()
    {

    }

    


}

