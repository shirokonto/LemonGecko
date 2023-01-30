# Lemon Gecko

Lemon Gecko (short for Leap Motion Gesture Control) is an application which allows to control a screen reader on a Windows operating system using hand gestures.
For this, the hand tracking device called [Leap Motion](https://www.ultraleap.com/) Controller is used, with which gestures can be recognized and mapped to individual keystrokes.
The eight gestures available to users are:
* ScreenTap
* HandSwipe in all four directions (Up, Down, Left and Right)
* Circle in two directions (Clockwise and Circleclockwise)
* Punch 

The execution of the gestures is described in detail in the Help view of the user interface.

## Presteps
1. Download the setup.exe or LemonGeckoSetup provided in this [LemonGeckoSetupV1.0.0.zip](https://github.com/shirokonto/ScreenReaderControlViaLMGestures/files/10537604/LemonGeckoSetupV1.0.0.zip) and run the installation.
2. Create an account at [Ultraleap](https://developer-archive.leapmotion.com/v2) in order to download the V2 Desktop-Asset with the last released version LeapDeveloperKit_2.3.1+31549_win
3. Unzip the downloaded LeapDeveloperKit-directory and run the client software Leap_Motion_Installer_release_public_win_x86_2.3.1+31549_ah1886
4. Start the application Lemon Gecko with administration rights (needed to change the gesture-key mapping) 

If the error "TypeInitializationException: The type initializer for 'Leap.LeapPINVOKE'threw an exception" occurs, when running the application, the Leap Motion .NET code cannot find the correct native library. In order to fix this issue copy the Leap.dll and LeapCSharp.dll from the LeapDeveloperKit directory ..\LeapDeveloperKit_2.3.1+31549_win\LeapSDK\lib to the same directory as the LemonGecko.exe (by default at C:\Program Files\Lemon Gecko\LemonGecko).

## Usage
In order to start the gesture control, two components are necessary: an active screen reader and the Leap Motion Controller.
The supported screen readers are NVDA, JAWS and Narrator, for each of which a set of default keystrokes is available and can be changed in the Settings view.
When both of the components are active the gesture control (session) can be started via the Home view. An ascending tone sequence sounds and the application window minimizes, bringing the focus on the next foreground application.



