# Tinball
A game very much made after the classic idea of a pinball game. You have a ball, you shoot it into the level, and use the flippers at your disposal in hope of trying to get as many points before you run out of attemps.

The game consists of
-	The sphere: The main object of the game, used to shoot around the level and collect points.
-	The Bumpers: Obstacles that bouncy you with even more force on impact, while giving you some points.
-	Coins: The real target you wanna go for, pickups that grant points and spawn after a couple of seconds. Found at the top of the map.
-	The level/ bounds: Made with probuilder, the main play area of the game controling where the ball can and will go.
-	Score system: The system that tracks your score as you hit obstacles and pickup coins throughout the game.
-	Lives: The amount of attempts the player has, before the game ends. Fret not though, you're just a button click away from replaying it.

## Project Setup

### Scripts
- Ball script: Used to control the position and physics of the ball.
- ScoreOnHit: A script mainly made for using switch cases, giving out points when the ball collides with a bumper or pickup. 
- ScoreManager: The script used for keeping track of the players score, and displaying it in the UI
- CoinManager: Used for respawning the coins after pickup
- Pickups: Used for rotation of the pickups, as well as aplying the score as visual elements of the coins
- Spring Script: Used for moving the spring up and down, allowing the player to launch the sphere
- Flipper Script: Used for flipping the flippers in the game, allowing the player to move the sphere after it has entered the bounds
- Main Menu: Used for controlling the menu UI, depending on the state of the game

### Game assets and materials
- All the game assets are made from scratch either by using normal unity shapes, or Probuilder.
- Physics materials have been used to change the friction between the ball and the colliding material

| **Task**                                                                | **Time it Took (in hours)** |
|--------------------------------------------------------------------------------|------------------------------------|
|     Setting up Unity project                                                   |     0.5                            |
|     Brainstorming ideas                                                        |     0.5                            |
|     Making Level with ProBuilder                                               |     2.5                            |
|     Figuring out and setting up input system                                   |     0.75                           |
|     Making flippers                                                            |     0.75                           |
|     Making Spring and ball (as well as their scripts)             |     1.5                            |
|     Making pickups and script for score management         |     1.5                              |
|     Setting up pickup timers and respawns          |     1                              |
|     Making Menu UI and a life counter           |     1.5                            |
|     Tinkering with physics                        |     0.5                            |
|     Code documentation       |     0.75                            |
|     Playtesting   and bugfixing fringe cases in rigidbody incorrect physics    |     1.5                            |
|     Code   documentation                                                       |     1                              |
|     Making readme                                                              |     0.5                            |
|     **All**                                                                        |     **13.25*                           |
