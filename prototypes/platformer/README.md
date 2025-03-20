reflaction
======
### platformer-1

1. This is a very basic version, used to test the basic functions of platformimg 

2. I first wanted to use the character controller to control the character, but I then found that the collider didn't work. I later learned that the character controller can't be used in 2D 

3. I'm trying to use a box collider to simulate the isgrounded effect in the character controller. This works, but as long as the character is touching the platform, it will be considered as standing on the platform, even if the character is underneath the ground. I solved this problem by using the height contrast between the character and the platform.

4. Coins will be "collected" when touched, but there will be no changes in this version, just functional testing

![alt text](https://github.com/hl1752a/game-dev-spring2025/blob/main/img/1.jpg)

[Play platformer-1](https://hl1752a.github.io/game-dev-spring2025/builds/platformer-1)




### platformer-final

1. I added animations to the character so that he can walk, jump, and attack.

2. I added health bar and fall damage, and there will be screen effects when the player is dying. Hearts on the map can restore health for players

3. I added a UI that can display the number of collected coins

4. I added a rotating platform that was not easy to pass, and I made the character teleport to the starting point when he fell

5. At the end of the level I added an enemy, which also has animations and can normally injure and be killed by the player.


![alt text](https://github.com/hl1752a/game-dev-spring2025/blob/main/img/fin.jpg)

[Play platformer-1](https://hl1752a.github.io/game-dev-spring2025/builds/platformer-final)

