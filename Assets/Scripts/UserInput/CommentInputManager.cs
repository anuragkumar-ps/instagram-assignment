using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UserInput
{
    public class CommentInputManager : MonoBehaviour
    {
        [SerializeField] private GameObject commentContainer;
        [SerializeField] private GameObject commentPrefab;
        [SerializeField] private RectTransform parentPostRectTransform;
    
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
            comment.GetComponent<UI.CommentUI>().Setup(inputText);
            _inputField.text = "";
            _inputField.ActivateInputField();
        
            LayoutRebuilder.ForceRebuildLayoutImmediate(comment.GetComponent<RectTransform>());
            LayoutRebuilder.ForceRebuildLayoutImmediate(commentContainer.GetComponent<RectTransform>());
            LayoutRebuilder.ForceRebuildLayoutImmediate(parentPostRectTransform);
        }

        private void OnDestroy()
        {
            _inputField.onSubmit.RemoveListener(OnCommentSubmit);
        }
    }
}
