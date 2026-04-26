# Simple 3D Platformer Game

A 3D Platformer Game developed using Unity.

## 📖 Description
The Simple 3D Platformer Game is a 3D game developed in Unity where the player controls a fully animated 3D character that can run and jump freely in a 3D environment. The main objective of the game is to navigate across a series of platforms, jump over gaps, and collect coins scattered throughout the level.

## 🎮 Controls
* **Movement:** The player uses the keyboard (WASD or Arrow keys) to move in 3D space.
* **Jump:** Presses the Spacebar to jump.

## ✨ Features
* The game features a user interface (UI) system including a Start Menu, a Game Over screen, and a Level Complete screen managed by a centralized GameManager.
* This project demonstrates key Unity concepts such as 3D character movement, state-machine animation blending (Idle, Run, Jump), trigger-based item collection, and UI management using C# scripting.

## 🏗️ Scene Setup
| GameObject | Component | Key Settings |
| :--- | :--- | :--- |
| Player (HumanSpecies_01) | Rigidbody, Capsule Collider, Animator | Gravity Scale = 2, Freeze Rotation (X, Y, Z), Controller = PlayerAnimator |
| Level (Floors) | Box Collider | Solid platforms for the player to walk on |
| Coin | Sphere Collider | Is Trigger = ON, Tag = "Coin" |
| GameManager | GameManager Script | Start Panel, GameOver Panel, and LevelComplete Panel assigned in Inspector |
| Canvas | UI Elements | Contains StartButton, RestartButton, and CoinsText |

## 💻 Core Scripts
* `GameManager.cs`
* `ItemCollector.cs`
* `PlayerMovement.cs`

## 👨‍💻 Developer
**Pondharani Devendra**
* Information Technology Student | Full Stack Developer in Training
* S.I.W.S. Colleges, Mumbai, Maharashtra
* **GitHub:** [@Dharani-dev22](https://github.com/Dharani-dev22)
* **LinkedIn:** [Pondharani Devendra](https://www.linkedin.com/in/pondharani-devendra-a809b339b/)
