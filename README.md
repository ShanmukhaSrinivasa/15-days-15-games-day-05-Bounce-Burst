# 15-Days-15-Games-Day-05-Bounce-Burst

This is the fifth game from my "15 Days 15 Games" challenge. It is a 2D "time attack" game where the player's objective is to click on and destroy all target objects in the shortest time possible.

## 🚀 About the Game
The player is presented with a number of bouncing balls on screen. A timer starts, and the player must click on each ball to destroy it. Once all balls are destroyed, the timer stops. The player's time is recorded, and the goal is to achieve the lowest time possible.

## 💡 Technical Highlights
* **Engine:** Unity (2D Physics)
* **Scalable Object Management:** The `GameManager` uses a `List<GameObject>` to manage all target "ball" objects. This allows the game's difficulty and scope to be changed easily from the Unity Inspector without altering code, as the win condition (`targetBallCount`) is dynamically set based on the list's size (`ballsInScene.Count`).
* **"Lower is Better" Scoring:** The game features a time-based scoring system where a lower score is superior. The best time is saved persistently between sessions using `PlayerPrefs.GetFloat` and `PlayerPrefs.SetFloat`.
* **Time Formatting:** The UI timer is formatted to two decimal places using the `.ToString("F2")` method for a more polished and professional look.

## ▶️ Play the Game!
You can play the game in your browser on its itch.io page:
**https://shanmukha.itch.io/bounce-burst**
