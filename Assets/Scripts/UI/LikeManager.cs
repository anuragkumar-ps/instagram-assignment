using UnityEngine;

namespace UI
{
    public class LikeManager : MonoBehaviour
    {
    
        [SerializeField] private GameObject heartFilled;
        [SerializeField] private GameObject heartUnfilled;
        

        public void OnLikePressed()
        {
            if (heartFilled.activeInHierarchy)
            {
                heartFilled.SetActive(false);
                heartUnfilled.SetActive(true);
            }
            else
            {
                heartFilled.SetActive(true);
                heartUnfilled.SetActive(false);
            }
        }
    }
}