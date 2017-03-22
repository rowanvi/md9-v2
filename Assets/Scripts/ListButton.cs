using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ListButton : MonoBehaviour {

    public Button buttonComponent;
    public Text nameLabel;
    public RawImage iconImage;


    private void buttonClicked()
    {
        name = nameLabel.text;
        //get url from name

        SaveDataManager.Instance.previewImageName = name;
        loadScenePreview();
    }


    public void buttonClickedSelect()
    {
        name = nameLabel.text;
        //get url from name

        SaveDataManager.Instance.previewImageName = name;
        loadSceneSelect();
    }


    private void loadScenePreview()
    {
        SceneManager.LoadScene("Preview_Screen");
    }

    private void loadSceneSelect()
    {
        SceneManager.LoadScene("FootballField_Screen");
    }

}



