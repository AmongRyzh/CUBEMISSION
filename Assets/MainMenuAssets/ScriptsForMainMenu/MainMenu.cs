using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // ������ �������!
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ContinueGame()
    {
        SaveObj player = new SaveObj();
        if (player.hasSaveInFile)
        {
            SceneManager.LoadScene(player.level);
        }
    }
    // ������ �������!
    public void ExitGame()
    {
        Debug.Log("����� �� ������ ���� ������ ������� ���������?!?!!!?!?!?!?!?!?!?!?!?!??!?!");
        Application.Quit();
    }
    // �� ������� ������� ��� ������!
    public void OnDiscordButtonDown()
    {
        Debug.Log("�������� �������!");
        Application.OpenURL("https://discord.gg/2xuNfK23NY");
    }
    public void OnFacebookButtonDown()
    {
        Debug.Log("�������� �������!");
        Application.OpenURL("https://www.facebook.com/zingstikbotproductions.official");
    }
    public void OnInstagramButtonDown()
    {
        Debug.Log("�������� ���������!");
        Application.OpenURL("https://www.instagram.com/zingstikbotproductions_off/");
    }
    public void OnTwitterButtonDown()
    {
        Debug.Log("�������� �������!");
        Application.OpenURL("https://twitter.com/StikbotZing");
    }
    public void OnVKButtonDown()
    {
        Debug.Log("�������� ��!");
        Application.OpenURL("https://vk.com/zingstikbotproductions.official");
    }
    public void OnYTButtonDown()
    {
        Debug.Log("�������� ����!");
        Application.OpenURL("https://www.youtube.com/channel/UCSz3k34PBTeDiuFWIY9MpAw");
    }
}
