using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartCutscene : MonoBehaviour
{
    public float seconds;

    private void Awake()
    {
        StartCoroutine(Cutscene());
    }

    IEnumerator Cutscene()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
