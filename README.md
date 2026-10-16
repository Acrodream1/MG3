# MG3
## Devlog

1. The default values for a float, int, bool, and string are 0, 0, false, and an empty string respectively.
2. The update method gets called every frame by Unity itself. The code only defines what update does. 
3. Both KickWeapon and TimerText use the Timer class to create timers. TimerText creates a game timer while KickWeapon creates activation timers. While they are both used differently, each timer is counted down every frame with Unity's built-in update method. The update method subtracts the time left with each time passed each frame (using deltatime). This allows for the timer to decrease while allowing gameobjects to handle their own logic without yielding.

## Open-Source assets
- [Cat fighter spritesheet](https://opengameart.org/content/cat-fighter-sprite-sheet)
- [Food sprites](https://rcpstd.itch.io/pixel-food-pack)