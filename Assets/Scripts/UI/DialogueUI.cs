using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour
{

    private TextMeshProUGUI nameText;
    private TextMeshProUGUI contentText;

    public Button continueButton;

    private List<string> contentList;

    private int contentIndex = 0;

    private void Start(){
        nameText = transform.Find("NameTextBg/NameText").GetComponent<TextMeshProUGUI>();
        contentText = transform.Find("ContentText").GetComponent<TextMeshProUGUI>();
        continueButton = transform.Find("ContinueButton").GetComponent<Button>();
        continueButton.onClick.AddListener(OnContinueButtonClick);

        Hide();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Show(string name, string[] content)
    {
        print("3");
        nameText.text = name;
        contentList = new List<string>();
        contentList.AddRange(content);
        contentText.text = contentList[0];
        Show();
    }

    public void Hide()
    {
        print("4");
        gameObject.SetActive(false);
    }

    public void OnContinueButtonClick(){

        print("5 " + contentIndex);
        contentIndex++;
        if(contentIndex >= contentList.Count){
            Hide();
            return;
        }
        contentText.text = contentList[contentIndex];
        
    }

}
