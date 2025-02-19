# Delivery Driver 🚗📦

A 2D driving game built with Unity where players navigate through the city to pick up and deliver packages while avoiding obstacles.

## Game Overview

In Delivery Driver, you take on the role of a delivery driver tasked with collecting packages and delivering them to customers. Navigate through the streets, avoid obstacles, and make efficient deliveries while managing your speed and vehicle control.

## Features

- 🎮 Smooth top-down driving mechanics
- 📦 Package pickup and delivery system
- 🚦 Speed management system
  - Speed boosts for efficient driving
  - Speed reduction when hitting obstacles
- 🎨 Visual feedback for package status
- 📸 Dynamic camera following the player

## Controls

- **W** or **↑** - Move forward
- **S** or **↓** - Move backward
- **A** or **←** - Turn left
- **D** or **→** - Turn right

## Game Mechanics

### Vehicle Control
- Base movement speed: 20 units
- Reduced speed after collision: 15 units
- Boost speed: 30 units
- Smooth steering control for precise navigation

### Delivery System
- Pick up packages by driving over them
- Deliver packages to marked customer locations
- Visual feedback through color changes when carrying packages
- Automatic package destruction after pickup

## Technical Details

### Core Components

1. **Driver.cs**
   - Handles vehicle movement and speed management
   - Manages collision responses and speed boosts

2. **Delivery.cs**
   - Controls package pickup and delivery logic
   - Manages visual feedback for package status

3. **FollowCamera.cs**
   - Implements smooth camera following mechanics
   - Maintains proper game view during movement

## Setup and Installation

1. Clone this repository
2. Open the project in Unity (recommended version: 2021.3 or later)
3. Open the main scene in the Assets folder
4. Press Play to test the game

## Development

This project is built using:
- Unity Game Engine
- C# for scripting
- 2D sprites and physics

## Contributing

Feel free to fork this project and submit pull requests for any improvements you'd like to add.

## License

This project is open source and available under the MIT License.
