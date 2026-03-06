using UnityEngine;

namespace UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private GameObject homeScreen;
        [SerializeField] private GameObject profileScreen;

        [SerializeField] private GameObject homeSelected;
        [SerializeField] private GameObject profileSelected;
        
        public void OnHomeScreenPressed()
        {
            profileScreen.SetActive(false);
            homeScreen.SetActive(true);
            homeSelected.SetActive(true);
            profileSelected.SetActive(false);
        }

        public void OnProfileScreenPressed()
        {
            homeScreen.SetActive(false);
            profileScreen.SetActive(true);
            homeSelected.SetActive(false);
            profileSelected.SetActive(true);
        }
    }
}