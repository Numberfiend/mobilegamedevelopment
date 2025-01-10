# Project Name: Fantasy Quest
**ESSENTIAL LINKS AND INFORMATION**
Github Link : https://github.com/Numberfiend/mobilegamedevelopment
Itch.io Link : https://numberfiend50.itch.io/zodiac
Youtube Video Link (if MP4 is broken for any reason) : https://youtu.be/vV8IEypB6a4
InternalTestingLink (Only works for the account I added to the testers list) : https://play.google.com/apps/internaltest/4701227008213428632

*File Structure as follows*
mobile_Joshua_22153027-------------------->APKsAndABBs----------------->(This is where the APK is)
                      -------------------->DevelopmentSketches--------->(This is where hard copies of my development sketches can be found)
                      -------------------->ProjectFiles---------------->(The folder labelled "fantasyquest" is the project folder in there)
                      -------------------->ReadMe---------------------->(where a copy of this github readme is)
                      -------------------->Video----------------------->(This is where the MP4 file is)
**Level Resetting**
If you need to reset the levels to play again since ther is no automatic way to atm please either A just open up the levels scene and press play or find the level checker script and copy and paste this code into the start function:
PlayerPrefs.SetInt("level1state", 0);
PlayerPrefs.SetInt("level2state", 0);
PlayerPrefs.SetInt("level3state", 0);
PlayerPrefs.SetInt("level4state", 0);

                      
**Set**
This is a game set in the fictional land of Auroran. Gelathar (That's you) has set out on a quest to become the worlds strongest swordsman and you must aid him in his quest to defeat all the enemies in your way
![image](https://github.com/user-attachments/assets/8fd5c685-d8e6-4856-b576-571081861e5e)


## Project Brief
The project brief challenged us to create a mobile application on either Android or iOS, I have developed my game, Zodiac, in the Unity Game Engine. This ReadMe acts as a brief summary of my work in this module but please refer to my video or code if you would like to take a deeper dive into the actual project files

## Game Overview
My game is a idle turn based game in which the player must complete a gaunlet of different enemies and defeat them in order to get achievements through google play. The turn based nature of the game is simple. In a given time limit (60 seconds or below) you must defeat the boss of the level using your attacks. In this final build for submission you can see that you have tow modes of attack, first is a melee attack to hit the enemy and the second is a magic meteor attack. In future versions of the games I would love to add in more and more attack types a player can unlock so that a player can create their own unique identity

## Project Features (See the video for a more detailed description of each 
- Joysticks movement using Unitys new input system and Gyro movement using the gyro within your mobile device (Works on internal testing, APK build and unity build)
- Vibrations using CandyCoded API (This is device agnostic which means when ported over it will work regardless of the devices OS)
- Unity Ads (Banner Ad is displayed at the bottom of the screen whenever you play the game, standard ads will interrupt the game 5 seconds after you load up the WorldMap scene)
![interadd](https://github.com/user-attachments/assets/f9549a89-c317-4de8-ab45-122fe88b5fc3)
- GooglePlayServices (Google Play tracks achievements and leaderbaords in order to make sure that the player can progress and feel as though their actions matter)
- Very responsive UI that works regardless of screensize
![canvas](https://github.com/user-attachments/assets/63b64895-f0d1-4749-b9b4-37ed042d2556)
![menu](https://github.com/user-attachments/assets/fd040e29-6c51-4fda-9137-94b635413986)


## Project Management
So primarily this project was managed through this GitHub as the project remained very small in scope I did not need to use external tools like Trello in my project and instead I found just writing a list and working my way through it the best option. Task were divided up into major segments such as (CHARACTERS, BATTLE SYSTEM, MENU SYSTEMS) etc. I would create all the scenes I know I would need and then populate them one by one crossing the tasks off the list and while perhaps not the most efficent method I do feel as though it was very successful and created a great final project outcome. 

## Credits
- Any online resources for figuring out code will be linked in the relevant scripts and listed here when the project is further along
- While ideally I would love to have custom models and animations for everything. Thinking realisitcally for now the models and animations will be sourced from the likes of Sketchfab, Mixamo. But certain objects I may need can still be modelled by hand. All references will be placed here when the project is further along too
- (Models and Animations came from) -  https://www.mixamo.com/#/
- (2D assets from) - https://opengameart.org/
- (Sound effects from) - https://uppbeat.io/browse/trending and https://pixabay.com/
- (Menu Icons from) - https://icons8.com/

