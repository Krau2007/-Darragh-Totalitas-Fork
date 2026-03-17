using UnityEngine;
using System.Collections;
using System.Collection.Generic;
using unityEngine.UIElements;

public class MainMenuFunction : MonoBehaviour
{
    private UIDocument  _document;

    private Button  _button;

    private void Awake()
    {
         _document = GetComponent<UIDocument>();

         _button = _document.rootVisualElement.Q("Start") as button:
         _button.RegisterCallBack<ClickEvent>(OnPlayGameClick)
    }
        private void OnDisable()
    {
        _button.UnregisterCallBack<ClickEvent>(OnPlayGameClick);
    }
    private void OnPlayGameClick(ClickEvent evt)
    {
        Debug.Log("You pressed the start button");
    }

}
