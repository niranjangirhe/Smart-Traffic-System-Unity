Made by:
Ibrahim Aladross
March 8, 2021

-This tool was designed to make it easy for you to get inputs from Xbox controllers.
-It supports up to 8 controllers by default.
-Examples for how to use this kit can be found in explanations below.




InputAxisGenerator
  -Prior to using the InputManager, you must generate Input Axes. The InputAxisGenerator component 
   can be used in the editor to generate all recommended XBOX axes. 
      1. Attach the component to an empty game object.
      2. Click "Generate Recommended XBOX Axes" only once.
      3. Patiently wait for unity to update the input manager axis list. This may take 1-2 minutes.
  -Once you have generated all the recommended axes, it is advised to delete this component from your game. 
   It is only needed to set up the input manager for you.






InputManager 
  -The InputManager class is in charge of taking all inputs from the controllers and updating static
   variables accordingly. You can access these variables from any other script by referring to InputManager.
   There is no need to use the Unity Input class when you have the InputManagerSingleton active.

  -The InputManagerSingleton must be active in the scene for the InputManager class to update.

  -All inputs are stored in an XboxController array variable called controllers.




  -To access axis input values on a specific controller, see the examples below:
     
     //The controller index ranges from 0-7 inclusive.
     float axisValue = InputManager.controllers[1].GetLeftStickX(); 

     //The controller index is one less than player number. 
     //0 indicates the first controller connected.
     //1 indicates the second controller connected.
     //2 indicates the third controller connected.
     float axisValue = InputManager.controllers[0].GetRightTrigger();

     //These values can be used in the same way as Unity's Input.GetAxis();
     //Values returned are in the range from 0-1 inclusive inclusive.



  -ButtonState: 
     "isPressed" is active for only one frame similar to Unity's GetKeyDown
     "isHolding" is active while the button is held down similar to Unity's GetKey
     "isReleased" is active for only one frame similar to Unity's GetKeyUp
     "isReady" is active while the button is not down, opposite of "isHolding"


  -To access button states on a specific controller, see the examples below:
     
     //This will call the function only one time when Player 1 presses "A"
     if (InputManager.controllers[0].GetButtonAState() == XboxController.ButtonState.isPressed)
         CallFunctionHere();

     //This will call the function up to once per frame when Player 2 holds down "A"
     if (InputManager.controllers[1].GetButtonAState() == XboxController.ButtonState.isHolding)
         CallFunctionHere();

     //This will call the function only one time when Player 1 lets go of "A"
     if (InputManager.controllers[0].GetButtonAState() == XboxController.ButtonState.isReleased)
         CallFunctionHere();

     //This will call the function up to once per frame when Player 5 is not holding "A"
     if (InputManager.controllers[4].GetButtonAState() == XboxController.ButtonState.isReady)
         CallFunctionHere();
   







XboxController 

  -The XboxController class is used to organize inputs for each player's controller. Functions are named
   with Get and Set to remind you not to change values in other scripts, although you can if needed.
   These values should typically only be set by the InputManager class, unless you are implementing some
   kind of macros or AI.

  -Each instance of XboxController has a reference to the player index. This matches the player number.

