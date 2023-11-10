// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class SceneSwitcher : MonoBehaviour
// {
//     public GameObject image; // Reference to the GameObject containing the image to show/hide.

//     private void Update()
//     {
//         if (Screen.orientation == ScreenOrientation.Portrait)
//         {
//             image.SetActive(true); // Show the image.
//         }
//         else if (Screen.orientation == ScreenOrientation.LandscapeLeft)
//         {
//             image.SetActive(false); // Hide the image for left landscape orientation.
//         }
//         else if (Screen.orientation == ScreenOrientation.LandscapeRight)
//         {
//             image.SetActive(false); // Hide the image for right landscape orientation.
//         }
//     }
// }


using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject image;

    private void Start()
    {
        CheckOrientation();
    }

    private void Update()
    {
        CheckOrientation();
    }

    private void CheckOrientation()
    {
        if (Screen.width > Screen.height)
        {
            // Landscape orientation
            image.SetActive(false);

        }
        else
        {
            // Portrait orientation
            image.SetActive(true);
        }
    }
}