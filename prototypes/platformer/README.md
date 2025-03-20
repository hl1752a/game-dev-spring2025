reflaction
======
### breakout-1

1. In this version, I made a basic breakout game. I mainly learned the simple physics system in Unity and the uses of Collider, for example, the ball should break bricks instead of walls. 

2. I also added an idea of ​​mine, that is, the player will rotate the camera while controlling the paddle to make the control more difficult.

![alt text](https://github.com/hl1752a/game-dev-spring2025/blob/main/img/1.jpg)

[Play Breakout Prototype-1](https://hl1752a.github.io/game-dev-spring2025/builds/breakout-1/)



### breakout-2a&2b

1. I tried to add more mechanics in this version: portals and gravity. In practice, I finished 2b first and then 2a, which removed the camera rotation to make it easier.

2. I learned how to change the direction of the force and make the gravity always point downwards. At the same time, I also learned how to use animators to make the portal move back and forth forever.

3. In earlier versions, gravity would slow the ball down and eventually stop it from bouncing. This allowed testers to make the ball never fall. I later fixed this by making the ball's speed always constant in the script.
   
4. In the playtest, testers generally felt that version 2b was too difficult and uninteresting. While the simple version 2a made testers feel that the mechanism was very interesting.

![alt text](https://github.com/hl1752a/game-dev-spring2025/blob/main/img/2a.jpg)
![alt text](https://github.com/hl1752a/game-dev-spring2025/blob/main/img/2b.jpg)

[Play Breakout Prototype-2a](https://hl1752a.github.io/game-dev-spring2025/builds/breakout-2a/)
[Play Breakout Prototype-2a](https://hl1752a.github.io/game-dev-spring2025/builds/breakout-3a/)


### breakout-3

1. In this version, I no longer make my "creations" accessible from the beginning. I made them random drops after destroying bricks.

2. I wanted to change the color of the falling effect ball over time, so I wasted a lot of time writing scripts. But in the end I realized that animators can easily achieve color changes.

3. Each effect is temporary, so I had to create 3 timers separately. I learned that I can use an empty object as a game manager to manage different timers.

4. Feedback from playertests indicated that this change made the game more interesting, because the effects dropped randomly. However, testers also reported that they had no way of knowing the current effects and their remaining time.

![alt text](https://github.com/hl1752a/game-dev-spring2025/blob/main/img/3.jpg)

[Play Breakout Prototype-3](https://hl1752a.github.io/game-dev-spring2025/builds/breakout-3/)



### breakout-final

1. In the final version, I added a UI to show the current effect and remaining time

2. I don't want to see the UI when there is no effect. I tried to modify the renderer at first but failed, it seems that TextMeshPro does not use the meshrenderer. Later I learned that I can directly modify the alpha value of the text to make them transparent and thus hidden.


![alt text](https://github.com/hl1752a/game-dev-spring2025/blob/main/img/fin.jpg)

[Play Breakout Prototype-final](https://hl1752a.github.io/game-dev-spring2025/builds/breakout-final/)

