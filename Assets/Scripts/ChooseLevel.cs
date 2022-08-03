using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChooseLevel : MonoBehaviour
{
    public Button Level2;
    public Button Level3;
    public Button Level4;
    public Button Level5;
    public Button Level6;
    public Button Level7;
    public Button Level8;
    public Button Level9;
    public Button Level10;
    int levelComplete;


    // Start is called before the first frame update
    void Start()
    {
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        Level2.interactable = false;
        Level3.interactable = false;
        Level4.interactable = false;
        Level5.interactable = false;
        Level6.interactable = false;
        Level7.interactable = false;
        Level8.interactable = false;
        Level9.interactable = false;
        Level10.interactable = false;

        switch(levelComplete)
        {
            case 1:
            Level2.interactable = true;
            break;
            case 2:
            Level2.interactable = true;
            Level3.interactable = true;
            break;
            case 3:
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
            break;
            case 4:
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
            Level5.interactable = true;
            break;
            case 5:
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
            Level5.interactable = true;
            Level6.interactable = true;
            break;
            case 6:
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
            Level5.interactable = true;
            Level6.interactable = true;
            Level7.interactable = true;
            break;
            case 7:
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
            Level5.interactable = true;
            Level6.interactable = true;
            Level7.interactable = true;
            Level8.interactable = true;
            break;
            case 8:
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
            Level5.interactable = true;
            Level6.interactable = true;
            Level7.interactable = true;
            Level8.interactable = true;
            Level9.interactable = true;
            break;
            case 9:
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
            Level5.interactable = true;
            Level6.interactable = true;
            Level7.interactable = true;
            Level8.interactable = true;
            Level9.interactable = true;
            Level10.interactable = true;
            break;
        }
    }

    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Reset()
    {
        Level2.interactable = false;
        Level3.interactable = false;
        Level4.interactable = false;
        Level5.interactable = false;
        Level6.interactable = false;
        Level7.interactable = false;
        Level8.interactable = false;
        Level9.interactable = false;
        Level10.interactable = false;
        PlayerPrefs.DeleteAll();
    }
}
