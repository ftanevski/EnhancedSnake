# EnhancedSnake

##### Windows Forms Project by Filip Tanevski(173165) and Andrej Kocev(173148).

## Summary

The idea behind the game Snake is generally known to all of us. The player controls a dot in the playing field, gathering food while it's moving in 1 of 4 directions, grows in size as
its eating the food, and thus leaving a trail behind in the form of a snake, hence the name.

### Main Menu

When the players start the application the first thing they will see is the main menu, where they will encounter 4 buttons with them being "Play Game", "Settings", "Help" and
"Exit Game", in that order from top to bottom which I will explain now.

#### Play Game Button

Self explanatory, by clicking the button the players are taken to a new form where they start playing the game.

#### Settings Button

By clicking the settings button the players will open a new form where they can adjust the game settings like how much food should spawn on the field at all times. **It's important to
note here that the players MUST have a number selected in the settings because otherwise food will not be spawned in the game.** There is also a back button which terminates the current
form and takes the player to the Main Menu.

#### Help Button

This button takes the players to a new form where there are instructions about how to play the game, as well as who made the game. There is also a back button which terminates the 
current form and takes the player to the Main Menu.

#### Exit Game Button

Also self explanatory, by clicking this button the players will terminate the form and with that the game will shut down.

## How to play

### Controls

In order to move the snake you will need to use the arrow keys on your keyboard:

← - to move the snake to the left;
↑ - to move the snake up;
↓ - to move the snake down and;
→ - to move the snake to the right.

### Mechanics

Once you start the game and go into the game window you should move the snake through the field to gather food and grow in size, and try to get as much food as possible.
Move the snake in the field using the arrow keys as explained above. However, in this version of snake there are powerup foods such as food that makes your snake slower by x0.5, 
and another that when you eat it will make your snake hover over its body and thus not ending the game if you crash into your own body. But also be wary of the trap food which 
speeds up your snake by x2 times.

## Problem Solution

In our Snake_and_food class we are keeping data about the X and Y coordinates of the snake, but also of the food that is supposed to spawn on the game field.
We are using this data in order to showcase the snake and the food on the Game Window form which the player eats in order to increase their highscore.

## Class Explanation

*private void EatFood():* if a collision is detected between the snake and the food thats spawned on the field, then by using this function we are able to delete the all the food
thats spawned on the field, as well as increase the size of the snake by 1, and the score by 1 as well.

## Screenshots

![Main Menu Screenshot](https://i.imgur.com/4UB6ymI.png "Main Menu")

---

![Help Menu Screenshot](https://i.imgur.com/vj6oAUz.png "Help Menu")

---

![Game Window Screenshot](https://i.imgur.com/s8hhn3L.png "Game Window")
