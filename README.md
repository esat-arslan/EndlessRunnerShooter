# 🏃‍♂️ Endless Runner

A Unity-based endless runner game developed as a portfolio project to showcase game development skills and programming expertise.

## 🎮 Game Overview

**Endless Runner 3D** is a fast-paced, action-packed endless runner where players control a character that automatically moves forward while dodging enemies and collecting power-ups. The game features a progressive difficulty system, multiple enemy types, and strategic power-up choices that affect gameplay.

🎥 Gameplay Demo

[![Watch the video](https://img.youtube.com/vi/scVINHF8ds4/hqdefault.jpg)](https://youtu.be/scVINHF8ds4)


## ✨ Key Features

### 🎯 Core Gameplay
- **Automatic Forward Movement**: Player continuously moves forward at increasing speeds
- **Lateral Movement**: Use left/right controls to dodge obstacles and enemies
- **Distance Tracking**: Real-time distance measurement displayed on screen
- **Progressive Difficulty**: Game becomes more challenging as you travel further

### 🔫 Combat System
- **Automatic Shooting**: Continuous bullet firing system
- **Enemy Collision**: Bullets destroy enemies on contact
- **Object Pooling**: Efficient bullet and enemy management for smooth performance

### 🚀 Power-Up System
- **Speed Boost**: Temporarily doubles player movement speed
- **Fire Rate Boost**: Reduces shooting interval for rapid-fire action
- **Multishot**: Fires multiple bullets simultaneously
- **Strategic Choice**: Choose between two different power-ups at gates

### 👾 Enemy System
- **Multiple Enemy Types**: 3 different enemy categories with varying spawn rates
- **Progressive Spawning**: Enemy difficulty increases based on distance traveled
- **Smart Spawning**: Enemies spawn ahead of the player at strategic distances
- **Object Pooling**: Efficient enemy management for smooth gameplay

### 🎨 Technical Features
- **Unity Input System**: Modern input handling for cross-platform compatibility
- **Universal Render Pipeline**: Optimized graphics for various platforms
- **Mobile Optimization**: Designed with mobile performance in mind
- **Audio Integration**: Sound effects for shooting and gameplay feedback

## 🛠️ Technical Implementation

### Architecture
- **Component-Based Design**: Modular scripts for easy maintenance and extension
- **Object Pooling**: Efficient memory management for bullets and enemies
- **Event-Driven Systems**: Clean separation of concerns between game systems
- **Configurable Parameters**: Easy-to-tune gameplay values through inspector

### Key Scripts
- `PlayerController.cs` - Core player movement and speed management
- `MobileMovement.cs` - Input handling and lateral movement
- `Shooting.cs` - Bullet spawning and firing mechanics
- `EnemySpawner.cs` - Dynamic enemy spawning with difficulty progression
- `EnemyStage.cs` - Configurable difficulty stages
- `PowerUp.cs` - Power-up activation and management system
- `ObjectPool.cs` - Efficient object pooling for performance
- `GateSpawner.cs` - Power-up gate spawning and management

### Performance Optimizations
- **Object Pooling**: Prevents garbage collection spikes
- **Distance-Based Culling**: Deactivates objects behind the player
- **Efficient Spawning**: Smart spawn timing and positioning
- **Memory Management**: Proper cleanup of inactive game objects

## 🎮 Controls

- **Left/Right Movement**: Use A/D keys, arrow keys, or gamepad left stick
- **Automatic Actions**: Forward movement and shooting happen automatically
- **Power-Up Selection**: Move through gates to activate power-ups

## 🔧 Customization

### Game Balance
- Adjust enemy spawn rates in `EnemySpawner.cs`
- Modify power-up durations in `PowerUp.cs`
- Tune player and enemy speeds in respective scripts
- Configure difficulty stages in `EnemyStage.cs`

### Visual Assets
- Replace placeholder enemy shapes with custom models
- Add particle effects for power-ups and combat
- Implement custom UI elements for enhanced presentation
- Add background music and additional sound effects

## 📱 Platform Support

- **PC**: Full support with keyboard and gamepad input
- **Mobile**: Optimized for touch controls and mobile performance

## 🎯 Future Enhancements

### Planned Features
- **Visual Polish**: Replace placeholder shapes with proper 3D models
- **Sound Design**: Background music and enhanced audio effects
- **UI Improvements**: Better HUD, menus, and visual feedback
- **Particle Effects**: Explosions, power-up effects, and visual polish
- **Score System**: High score tracking and achievements
- **Multiple Characters**: Different player characters with unique abilities

### Technical Improvements
- **Save System**: Progress persistence and settings
- **Analytics**: Player behavior tracking and game balance data
- **Localization**: Multi-language support
- **Accessibility**: Colorblind support and customizable controls

## 🏗️ Project Structure

```
Assets/
├── Scripts/
│   ├── Player/          # Player movement, shooting, and controls
│   ├── Enemy/           # Enemy spawning, movement, and difficulty
│   ├── PowerUps/        # Power-up system and gates
│   └── Pooling/         # Object pooling for performance
├── Prefabs/             # Game object prefabs
├── Scenes/              # Game scenes
├── Audio/               # Sound effects and audio
└── Settings/            # Render pipeline and project settings
```

## 🎓 Skills Demonstrated

This project showcases proficiency in:
- **Unity Game Development**: Core engine features and best practices
- **C# Programming**: Clean, maintainable code architecture
- **Game Design**: Balanced gameplay mechanics and progression
- **Performance Optimization**: Object pooling and efficient systems
- **Input Systems**: Modern Unity input handling
- **Component Architecture**: Modular and extensible design patterns
- **Cross-Platform Development**: Mobile and PC compatibility

## 📄 License

This project is developed as a portfolio piece. Feel free to use the code structure and concepts for learning purposes.

## 🤝 Contributing

This is a portfolio project, but feedback and suggestions are welcome! Feel free to:
- Report bugs or issues
- Suggest improvements or new features
- Share your own implementations or variations

## 📞 Contact

For questions about this project or collaboration opportunities, please reach out through your portfolio or professional channels.

---

**Developed with Unity and C#** | **Portfolio Project** | **Endless Runner Game**
