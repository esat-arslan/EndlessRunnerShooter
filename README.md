3D Endless Runner (Work-in-Progress)


🎮 Overview

This is a 3D endless runner game built in Unity with C#. The player controls a soldier character who constantly shoots forward while avoiding enemies and collecting power-ups. This project is a work-in-progress, showcasing core gameplay mechanics for portfolio purposes.

🚀 Gameplay

Player Character: Soldier that automatically shoots forward.

Movement: Player can move left or right using keyboard (A/D) or touchscreen joystick.

Bullets: Spawn from an object pool. Destroyed on hitting enemies or after a certain range. Bullet firing uses coroutines for timing.

Enemies: Spawn from an enemy pool. Currently placeholder objects (triangle, sphere, cube) that move toward the player at varying speeds depending on type.

Map Segments: There are 3 map segments that reposition in front of the player as they advance.

Power-Up Gates: Provide temporary buffs for 5 seconds:

Increased speed

Increased fire rate

Multi-shoot

Score: Based on distance traveled.

📂 Features

Core endless runner loop implemented

Object pooling for bullets and enemies for performance

Power-ups that modify player stats temporarily

Keyboard and touchscreen joystick controls

Modular map segments for seamless endless movement

Placeholder assets to demonstrate functionality

🛠 Tech Stack

Engine: Unity 2021+

Language: C#

Design Patterns: Singleton (for GameManager), Coroutines for bullets and spawning

📝 Notes

Work-in-progress: Core gameplay mechanics implemented; visuals, audio, and full enemy behaviors will be added later.

Portfolio focus: Demonstrates object pooling, coroutines, power-up mechanics, and endless runner logic.

🎥 Gameplay Demo

[![Watch the video](https://img.youtube.com/vi/scVINHF8ds4/hqdefault.jpg)](https://youtu.be/scVINHF8ds4)


⚡ Future Plans

Replace placeholder enemy objects with actual 3D models

Add sound effects and background music

Implement more diverse power-ups and enemy types

Polish UI and add start/game over screens

Add player health and death mechanics
