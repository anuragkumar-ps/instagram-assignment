using Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class PostUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text nameText;
        [SerializeField] private TMP_Text addressText;
        [SerializeField] private TMP_Text hashtagsText;
        [SerializeField] private Image postImage;

        public void Setup(PostData data, Sprite image)
        {
            nameText.text = data.name;
            addressText.text = data.address;
            hashtagsText.text = data.hashtags;
            postImage.sprite = image;
        }
    }
}
