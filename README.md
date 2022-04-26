# **SimplePlatformGame**
My first ever game made in Unity. It's really simple platform game. <br/>
All assets used in this project are from Unity Asset Store and are free to use.
<br/>
<br/>
### There is a [link](https://play.unity.com/mg/other/simpleplatformerweb) for you to play it

## **Table of contents**
<!--ts-->
   * [To be added](#to-be-added)
   * [Known bugs](#known-bugs)
   * [Updates](#updates)
<!--te-->
<br/>

## **To be added:**
- [ ] Up to 10 levels
- [x] Some kind of *Reset Level* option during playing
- [x] Movement instructions
- [ ] Player can be killed by enemies
- [ ] New type of enemy, moving vertically
- [ ] Ladders and player's on-ladder movement
- [ ] Sound
- [ ] Volume slider in Options Menu
- [ ] Working *Hard Mode* option in Options Menu
- [ ] *Control Settings* option in Options Menu
- [ ] Boss fight 

## **Known bugs:**
- Player can stuck on the edges

## **Updates**
### **Version 0.3:**
- New level added
- New button to exit level during playing
- Box bug fixed
- Fixed layer sorting

### **Version 0.2:**
- New level added
- Level summary optimization
  - Before: every level had its own summary
  - After: there is one summary scene where every level ends
- Better score counting up in level summary.
- Total score added as PlayerPref
- End Game scene added with total score counter
- Time needed to restart level after falling decreased

### **Version 0.1:**

- Simple movement (running, jumping, crouching, sprinting)
- Collectible gems, every collected gem equals one point
- Score is counting properly and displaying in the upper right corner
- Simple enemies, moving horizontally in straight line, killable by jumping on top of them
- Movable box
- Multiple platform, able to switch on and off by cranks, moving both horizontally and vertically
- Cranks, activate platforms by pressin E near them
- Simple Main Menu: 
  - *Play* button starts first level
  - *Options* button opens options menu which isn't finish yet
  - *Exit* button closes program
- First level is possible to finish
- Level summary with score counter, star-based grade scale and buttons:
  - *Main Menu* button goes back to Main Menu scene
  - *Retry* button starts again the same level
  - *Continue* button starts next level
- Player killable y position level, in case of getting out of the map, it resets level
