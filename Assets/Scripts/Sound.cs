using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sound : MonoBehaviour
{
    [SerializeField] private string createdTag;

    private void Awake()
    {
        GameObject obj = GameObject.FindWithTag(this.createdTag);
        if (obj != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            this.gameObject.tag = this.createdTag;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    private void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 10 || SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
