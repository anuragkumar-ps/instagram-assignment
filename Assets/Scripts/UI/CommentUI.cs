using TMPro;
using UnityEngine;

namespace UI
{
    public class CommentUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text commentText;

        public void Setup(string inputText)
        {
            commentText.text = inputText;
        }
    }
}
