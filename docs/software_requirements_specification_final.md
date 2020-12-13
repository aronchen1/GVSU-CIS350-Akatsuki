# Overview

The purpose of this document is to showcase our specfic requirements to have for our product. From the specifications of this document our players will be able to strategize and learn problem solving skills while playing the game. Also from this document we follow the gaming industries standards by having a stable game across the board.

# Software Requirements

(add here)
	
# Functionial

### Title Screen/Main Menu
| ID | Requirement | Test Cases |
| :-------------: | :----------: | :----------: |
| FR1 | This game shall allow the player to exit the game. | TBD |
| FR2 | This game shall let the user start a game thorugh the main menu. | TBD |
| FR3 | This game shall allow the user to adjust the in-game volume through the main menu. | TBD |
| FR4 | This game shall generate a pre-made level when pressing the start button in the main menu. | TBD |
| FR5 | This game shall play music when the Title screen is loaded. | TBD |


### Character Movement
| ID | Requirement | Test Cases |
| :-------------: | :----------: | :----------: |
| FR6 | Pressing the right arrow key shall make the chracter move right. | TBD |
| FR7 | Pressing the left arrow key shall make the character move left. | TBD |
| FR8 | Pressing the space bar key shall make the character jump. | TBD |
| FR9 | This game shall allow the user to control a sprite in-game. | TBD |
| FR10 | This game shall allow the user to jump if the character in-game is touching the ground. | TBD |


## Respawn System
| ID | Requirement | Test Cases |
| :-------------: | :----------: | :----------: |
| FR1 | Touching an enemy shall send the character back to the start of the leve.| TBD |
| FR2 | Falling off the map shall send the character back to the start of the level. | TBD |
| FR3 | Getting hit by an item thrown by the enemy shall send the character to the start of the level. | TBD |


### Pause Menu
| ID | Requirement | Test Cases |
| :-------------: | :----------: | :----------: |
| FR11 | This pause menu shall allow the user to pause the game. | TBD |
| FR12 | This pause menu shall allow the user to fully exit the application. | TBD |
| FR13 | This pause menu shall allow the user to adjust the in-game volume. | TBD |
| FR14 | This pause menu shall allow the user to resume the game from the pause state. | TBD |
| FR15 | This pause menu shall allow the user to exit to the Title Screen of the game. | TBD |



# Non-Functionals

(add here)

## Non-Functional Requirements

### System Requirements
| ID | Requirement | Test Cases |
| :-------------: | :----------: | :----------: |
| NFR1 | This Program shall display a screen with a 2-D field of Vision. | TBD |
| NFR2 | The system shall remember the user's best score. | TBD |
| NFR3 | The game shall run on any modern computer system. | TBD |
| NFR4 | The frames per second in this game shall be at a maximum of 60. | TBD |
| NFR5 | The level reset time after a failed attempt shall be less than 5 seconds | TBD |


1. User input
	1. This program shall take input from the keyboard to move a player.
	1. This program shall take input from the mouse to navigate the menus.
	1. 

1. User Interface
	1. The title screen shall be easy to navigate for every user.

1. Animation
	1. The animation of failing shall be obvious but not overly dramatic.

1. User Experience
	1. This program shall have an objective for the player to reach by moving through the level.




# Test Specification

(Description of what this section is)

## Unit tests

| ID | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC1 | If player moves right when pressing right arrow key. | Press right arrow key | Right arrow key | Player should move right | Player did move right | Pass | FR6 |
| TC2 | If player moves left when pressing left arrow key. | Press left arrow key | Left arrow key | Player shall move left | Player did move left | Pass | FR7 |
| TC3 | If the player jumps when pressing the spacebar. | Press Spacebar | Spacebar Key | Player should jump | Player did jump | Pass | FR8 |
| TC4 | Testing to see if the player only jumps when touching the ground. | Player on the ground, then jump | Spacebar key | Player should jump while on ground | Player did jump | pass | FR10 |
| TC5 | If the player is airborn, then the player should not be able to jump again. | Jump, then try jumping again whilie airborne | Spacebar key | Should not be able to jump | Did not jump | Pass | FR10 |
| TC6 | Pressing start button should trigger an event | Press the start button | Left Mouse click, Start button | Button is pressed and event starts | Button was pressed and event started | Pass | (requirement IDs this test case is linked to) |
| TC7 | Pressing Quit Game button should trigger an event | Left click on mouse while over Quit Game button | Left Mouse Click, Quit Button | Button is Pressed and event starts | Button was pressed and event started | Pass | (requirement IDs this test case is linked to) |
| TC8 | Testing volume slider | Slide the volume slider | The sound variable 0-1 | Volume should match the slider variable | Volume did match the slider varaible | Pass | FR3 |
| TC9 | Pressing ESC key should trigger an event | Press ESC key | ESC Key | Button pressed and event starts | Button was pressed event was triggered | Pass | FR11 |
| TC10 | Pressing Resume should trigger an event | Pause the game, Press resume | ESC Key, Left mouse click on Resume button | Button is pressed and event starts | button was pressed and event started | Pass | FR14 |

## Integration tests

| ID | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC11 | (TC1 description) | (steps to execute TC1) | (input values to this test case) | (expected output as a result of test case) | (actual output of test case) | (did it pass or fail?) | (requirement IDs this test case is linked to) |
| TC12 | (TC2 description) | (steps to execute TC2) | (input values to this test case) | (expected output as a result of test case) | (actual output of test case) | (did it pass or fail?) | (requirement IDs this test case is linked to) |
| TC13 | (TC3 description) | (steps to execute TC3) | (input values to this test case) | (expected output as a result of test case) | (actual output of test case) | (did it pass or fail?) | (requirement IDs this test case is linked to) |
| TC14 | (TC4 description) | (steps to execute TC4) | (input values to this test case) | (expected output as a result of test case) | (actual output of test case) | (did it pass or fail?) | (requirement IDs this test case is linked to) |
| TC15 | (TC5 description) | (steps to execute TC5) | (input values to this test case) | (expected output as a result of test case) | (actual output of test case) | (did it pass or fail?) | (requirement IDs this test case is linked to) |

## System tests

| ID | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-------------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: | :----------: |
| TC16 | Pressing start button starts the game | Left mouse click on start button | Start game button,Left mouse click | The game should start | The game was started | Pass | FR2 |
| TC17 | Pressing Quit Game button should fully exit application | Left mouse click on Quit Game | Quit Game button | Application should fully exit | Application was fully exited | Pass | FR1 |
| TC18 | Pressing ESC Key should pause the entire game | Press ESC key | ESC key | Entire game should be fully paused | Entire game was fully paused | Pass | FR11 |
| TC19 | Pressing Resume button unpauses the entire game | Press Resume Button | Resume Button | Game is unpaused from paused state | Game was unpaused from the paused state | Pass | FR14 |
| TC20 | Music Starts when the application is started | Start the build of the game | Left mouse click on build game | Music should start playing when the game is fired up | Music started playing when game was fired up | Pass | FR5 |

# Software Artifacts

This section provides hyperlinks to all artifacts developed for this project.

* [Mobility Use Case Diagram](https://github.com/calebpoe00/GVSU-CIS350-Akatsuki/blob/master/artifacts/use_case_diagrams/use_case_diagram_Mobility.png?raw=true)
* [Encountering Enemies Use Case Diagram](https://github.com/calebpoe00/GVSU-CIS350-Akatsuki/blob/master/artifacts/use_case_diagrams/use_case_diagrams_Encountering_Enemies.png?raw=true)
* [Main Menu Use Case Diagram](https://github.com/calebpoe00/GVSU-CIS350-Akatsuki/blob/master/artifacts/use_case_diagrams/use_case_diagram_mainMenu.png?raw=true)
* [Main Menu Extended](https://github.com/calebpoe00/GVSU-CIS350-Akatsuki/blob/master/artifacts/use_case_diagrams/main_menu_extended.md)
