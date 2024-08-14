<h1>AR Ludo Board Game</h1>

<h2>Description</h2>
Welcome to the AR Ludo Board Game project! This augmented reality game brings the classic Ludo board game into the digital world. 
Using Vuforia Engine and AR technology, the game leverages ImageTarget recognition to display the Ludo board when the AR camera detects the target. 
Players can interact with the game pieces using a drag-and-drop mechanism and spin the dice by pressing the spacebar.

<h2>Features:</h2>

Augmented Reality (AR) Integration: Recognizes an ImageTarget to display the Ludo board.
Interactive Board: Drag-and-drop functionality for moving game pieces.
Dice Mechanics: Press the spacebar to spin the dice.
Touch and Mouse Input: Compatible with mobile devices and desktops.

<h2>Installation:</h2>
Prerequisites
Unity: Ensure you have Unity installed (version X.X or later).
Vuforia Engine: This project uses Vuforia for AR functionality.
Steps to Set Up
Clone the Repository:

bash
Copy code
git clone (https://github.com/ailieva02/AR_Project.git)

<h2>Open the Project:</h2>

Open Unity and load the cloned project.

<h2>Configure Vuforia Engine:</h2>

Go to Edit > Project Settings > XR Plug-in Management.
Check the box for Vuforia Engine to enable AR functionality.
Install Required Packages:

Open the Package Manager in Unity (Window > Package Manager).
Add the Vuforia Engine package if not already included.
Ensure the AR camera package is installed and properly configured.
Set Up AR Camera and ImageTarget:

In the Unity scene, ensure the AR Camera and ImageTarget are set up according to your project needs.
Adjust the settings for the AR Camera to ensure it recognizes the ImageTarget.
Usage
Run the Project:

Press the Play button in Unity to test the game in the editor.
For mobile devices, build and deploy the project to your device.
Gameplay:

Point the AR camera at the ImageTarget to display the Ludo board.
Drag and drop pieces on the board to move them.
Press the spacebar to spin the dice.
Contributing
We welcome contributions to enhance the game or fix issues. To contribute:

Fork the repository.
Create a new branch (git checkout -b feature-branch).
Commit your changes (git commit -am 'Add new feature').
Push to the branch (git push origin feature-branch).
Open a Pull Request on GitHub.

For some reason we didn't manage to make the APX or EXE file work so here is a picture of the Bot you need as a ImageTarget :)
![ImageTarget](https://github.com/user-attachments/assets/6840e82b-ae5b-4e9f-b314-17c442dbd62e)
