using UnityEngine;
using UnityEngine.SceneManagement;
public class InputManagerSingleton : MonoBehaviour
{
    //Use this controller monitor to test inputs. Delete the line below when done.
    [SerializeField]
    XboxController[] controllerMonitorForEditor;
    void Awake()
    {
        InputManager.Initialize();

        //Delete the line below once you have confirmed input values are working as expected.
        controllerMonitorForEditor = InputManager.controllers;

        //Delete or modify the line below as needed. This component is a singleton used to 
        //track inputs from xbox controllers throughout the entire game experience
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }
    void Update()
    {
        InputManager.UpdateControllers();

        //Delete the line below once you have confirmed input values are working as expected.
        controllerMonitorForEditor = InputManager.controllers;
    }
}
