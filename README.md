# Archery-Game!

<img width="308" alt="Screen Shot 2023-05-31 at 16 02 12" src="https://github.com/inomisay/Archery-Game/assets/98346164/fa305ef1-bf27-4448-b6d1-a96be44cb6ec">

# Project:  Archery Game

The aim of the project is to develop an archery game with three opponent
archers. User (archer A) and two other opponents (B and C) take shots at 
each other with different types of arrows. 

# General Information

The game area coordinates are -10 to 10 grid in x and y.

Game Initialization

1. The first archer (A) represents the user. User enters the coordinates of his/her character. The program should control the validity of the location.

2. The second and third archers are placed in random locations in the game area. The archers should be shown on the coordinate plane.

3. Each archer has unique arrow and shield set. There are three types of arrows that give different damages to different shields: fire arrows (FA), poison arrows (PA), and iron-head arrows (IA). 

  Three types of shields (Heater, Wankel and Celtic) are available, which are made from different materials and have different shapes and protection against different arrows. 

<img width="863" alt="Screen Shot 2023-05-31 at 16 00 53" src="https://github.com/inomisay/Archery-Game/assets/98346164/e378d527-1fac-46ce-a217-8b935579562d">

  The archer with FA always wins against PA, PA against IA, and IA against FA. 
 
4. Each archer has different health state (60, 80 or 100), initiated randomly at the beginning of the game.

# Game Playing Rules

1. There are two rounds of attacks in each game. Each attack contains only 2 archers. In the first round, the closest two archers shoot at each other. After that, the winner and the other archer shoot at each other.   

2. An arrow can travel max. 15 units. Otherwise, there is no attack.

3. Each attack decreases 25 health points from the winner. The health point of the loser becomes zero.  

4. In each attack, only the winner gains some score points with respect to the following formula. 

  Attack Score = 10 * Manhattan_distance_between_archers + (100 - Archer's_health)

5. At the end of the game; status, health and scores of each archer must be printed on the screen. It should also be determined which archer (A or B or C) has the maximum score. 

# Sample Game Screens

<img width="571" alt="Screen Shot 2023-05-31 at 16 02 54" src="https://github.com/inomisay/Archery-Game/assets/98346164/12bb1b95-12e2-4ced-8f51-16203ff46821">


