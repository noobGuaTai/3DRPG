using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogUI : MonoBehaviour
{
    public static DialogUI Instance {get; private set;}
    TextMeshProUGUI nameText;
    TextMeshProUGUI dialogText;
    Button continueButton;
    List<string> contentList;
    int index = 0;

    void Awake(){
        if(Instance != null && Instance != this){//多个对话UI实例会被摧毁
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    void Start(){
        nameText = transform.Find("NPCName").GetComponent<TextMeshProUGUI>();
        dialogText = transform.Find("DialogText").GetComponent<TextMeshProUGUI>();
        continueButton = transform.Find("ContinueButton").GetComponent<Button>();
        continueButton.onClick.AddListener(this.OnContinueButtonClick);
        Hide();
    }

    public void Show(){
        gameObject.SetActive(true);
    }

    public void Show(string name, string[] content){
        gameObject.SetActive(true);
        nameText.text = name;
        contentList = new List<string>();
        contentList.AddRange(content);
        dialogText.text = contentList[0];
    }

    public void Hide(){
        gameObject.SetActive(false);
    }

    void OnContinueButtonClick(){
        index++;
        if(index >= contentList.Count){
            Hide();
            index = 0;
            return;
        }
        dialogText.text = contentList[index];
        
    }
}
