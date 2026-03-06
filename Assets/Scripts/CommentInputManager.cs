using System;
using TMPro;
using UnityEngine;

public class CommentInputManager : MonoBehaviour
{
    [SerializeField] private GameObject commentContainer;
    [SerializeField] private GameObject commentPrefab;
    

    private TMP_InputField _inputField;

    private void Awake()
    {
        _inputField = GetComponent<TMP_InputField>();
        _inputField.onSubmit.AddListener(OnCommentSubmit);
    }

    private void OnCommentSubmit(string inputText)
    {

        if (string.IsNullOrWhiteSpace(inputText)) return;
        
        var comment = Instantiate(commentPrefab, commentContainer.transform);
        comment.GetComponentsInChildren<TMP_Text>()[1].text = inputText;
        _inputField.text = "";
        _inputField.ActivateInputField();
    }

    private void OnDestroy()
    {
        _inputField.onSubmit.RemoveListener(OnCommentSubmit);
    }
}
