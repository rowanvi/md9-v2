using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu_Button : MonoBehaviour {

	// Use this for initialization
	public void LoadScanScreen () {
        SceneManager.LoadScene("Scan_Screen");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void LoadPreviewScreen()
    {
        SceneManager.LoadScene("Preview_Screen");
    }

    public void LoadPreviewList()
    {
        SceneManager.LoadScene("View_List");
    }

    public void LoadStartScreen()
    {
        SceneManager.LoadScene("Rowan_Test_Scene");
    }

    public void LoadStartSelectedScreen()
    {
        SceneManager.LoadScene("FootballField_Screen");
    }


}
