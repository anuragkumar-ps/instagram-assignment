using UnityEngine;

namespace UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private GameObject homeScreen;
        [SerializeField] private GameObject profileScreen;
    
        public void OnHomeScreenPressed()
        {
            profileScreen.SetActive(false);
            homeScreen.SetActive(true);
        }

        public void OnProfileScreenPressed()
        {
            homeScreen.SetActive(false);
            profileScreen.SetActive(true);
        }
    }
}