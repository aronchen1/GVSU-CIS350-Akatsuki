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
| TC1 | Testing to see if player moves right when pressing right arrow key. | Press right arrow key | Right arrow key | Player should move right | Player did move right | Pass | FR6 |
| TC2 | Testing to see if player moves left when pressing left arrow key. | Press left arrow key | Left arrow key | Player shall move left | Player did move left | Pass | FR7 |
| TC3 | Testing to see if the player jumps when pressing the spacebar. | Press Spacebar | Spacebar Key | Player should jump | Player did jump | Pass | FR8 |
| TC4 | Testing to see if the player only jumps when touching the ground. | Player on the ground, then jump | Spacebar key | Player should jump while on ground | Player did jump | pass | FR10 |
| TC5 | If the player is airborn, then the player should not be able to jump again. | Jump, then try jumping again whilie airborne | Spacebar key | Should not be able to jump | Did not jump | Pass | FR10 |
| TC6 | Testing the start button. | Press the start button | Left Mouse click, Start button | Button is pressed and event starts | Button was pressed and event started | Pass | (requirement IDs this test case is linked to) |
| TC7 | Testing Quit Button | Left click on mouse while over Quit Game button | Left Mouse Click, Quit Button | Button is Pressed and event starts | Button was pressed and event started | Pass | (requirement IDs this test case is linked to) |
| TC8 | Testing the volume slider | Slide the volume slider | The sound variable 0-1 | Volume should match the slider variable | Volume did match the slider varaible | Pass | FR3 |
| TC9 | Pressing ESC key should pause the game | Press ESC key | ESC Key | Game should be paused | Game was paused | Pass | FR11 |
| TC10 | Pressing Resume should trigger event | Pause the game, Press resume | ESC Key, Left mouse click on Resume button | Button is pressed and event starts | button was pressed and event started | Pass | FR14 |

## Integration tests

## System tests

# Software Artifacts

This section provides hyperlinks to all artifacts developed for this project.

* [Mobility Use Case Diagram](https://github.com/calebpoe00/GVSU-CIS350-Akatsuki/blob/master/artifacts/use_case_diagrams/use_case_diagram_Mobility.png)
* [Encountering Enemies Use Case Diagram](https://github.com/calebpoe00/GVSU-CIS350-Akatsuki/blob/master/artifacts/use_case_diagrams/use_case_diagrams_Encountering_Enemies.png)
* [Main Menu Use Case Diagram](https://github.com/calebpoe00/GVSU-CIS350-Akatsuki/blob/master/artifacts/use_case_diagrams/use_case_diagram_mainMenu.png)
* [Main Menu Extended](https://github.com/calebpoe00/GVSU-CIS350-Akatsuki/blob/master/artifacts/use_case_diagrams/main_menu_extended.md)
