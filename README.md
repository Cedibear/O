#O

## Description
This project aims to create a soccer game similar to EA Sports FC 25 with advanced gameplay mechanics, random teams, players, and leagues. The game includes multiplayer functionality using Photon Unity Networking (PUN) and is deployable on GitHub Pages.

## Features
- Advanced AI for realistic gameplay
- Dynamic lighting and shadows
- Improved player animations
- Realistic crowd reactions and sounds
- Career Mode with player development
- Player creation with custom name
- Player development based on performance
- Transfer market for player movement between teams
- Career goals and milestones
- Training sessions to improve skills
- In-game achievements and rewards
- Ultimate Team Mode with player cards and tournaments
- Manager Mode with team management and tactics
- Realistic injuries and recovery management
- Advanced match commentary
- Dynamic weather conditions
- In-depth statistics and analytics
- Authentic tournaments and leagues
- Skill moves and customizable celebrations
- Realistic ball physics
- Advanced tactics and formations
- Dynamic player emotions
- VAR (Video Assistant Referee)
- Realistic crowd and atmosphere
- Player energy and fatigue
- Multiplayer functionality using Photon Unity Networking (PUN)
- Player controls
- Different game modes (e.g., Exhibition, Tournament, Career Mode)
- AI-controlled teams
- Teams and stadiums
- Fan animations
- Tutorials for new players
- Realistic graphics and sound
- 90-minute game time with accelerated clock
- Opening page with "Ultimate Soccer Experience" title
- Sound effects for button clicks and game events
- Player celebration feature on scoring a goal
- Team chooser with random teams and players
- Multiplayer feature with room codes and team selection
- Home advantage and away team disadvantage
- Shooting and passing mechanics
- Corner shots with aiming and direction
- Card management using AI (Yellow and Red cards)
- Penalty kicks
- Free kicks with walls and defense
- Offside detection
- Extra time and penalty shootout for tied games
- Scoreboard to display the current score
- Player overalls and substitutions
- Hidden cursor during gameplay
- Glowing orb around the player with the ball
- Directional arrows for passing and shooting
- Player switching
- Camera follows the player as they move
- Special moves like rainbow flicks and jukes for players with over 90 overall (max overall is 95)
- Customizable controls via settings menu
- Signature celebrations for each player
- Squad view before starting the match
- Dynamic weather conditions
- Detailed statistics and career tracking

## Controls
- Movement: Arrow keys or WASD keys
- Shoot: Press and hold R (default, longer press for higher and longer shot)
- Pass: Press E (default)
- Switch Player: Press C (default)
- Free kick: Press Space to shoot (default)
- Corner kick: Press Space to aim and shoot (default)
- Rainbow Flick: Press Q (default)
- Juke: Press Z (default)

## Technologies
- Game Engine: Unity
- Programming Language: C#
- Graphics: Realistic art
- Sound: Realistic sound effects
- Multiplayer: Photon Unity Networking (PUN)
- Deployment: GitHub Pages

## Getting Started

### Prerequisites
- Unity Hub and Unity Editor installed
- Visual Studio or another C# IDE

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/<your-username>/<your-repo>.git
   ```
2. Open the project in Unity Hub.
3. Open the project in Unity Editor and start developing!

### Audio Setup
- Ensure that `button_click.wav`, `celebration1.wav`, `celebration2.wav`, `whistle.wav`, `yellow_card.wav`, and `red_card.wav` are in the `Assets/Audio/` directory.
- Attach the `AudioSource` component to the player game object.
- Link the `celebrationSound`, `whistleSound`, `yellowCardSound`, and `redCardSound` `AudioClips` to the respective scripts in the Inspector.

## Development

### Project Structure
- `Assets/`: Contains all game assets including scripts, graphics, and sound.
  - `Animations/`: Contains player animations.
  - `Photon/`: Contains Photon networking scripts.
  - `Scenes/`: Contains the main menu, multiplayer menu, team chooser, settings menu, and game scenes.
  - `Scripts/`: Contains C# scripts for game logic.
  - `Sprites/`: Contains realistic sprite assets and UI elements.
  - `Audio/`: Contains realistic sound effects.
  - `Teams/`: Contains team logos and player sprites.
  - `Stadiums/`: Contains stadium backgrounds.
  - `Fans/`: Contains fan sprites.
  - `Weather/`: Contains weather effects and assets.
  - `MainMenu/`: Contains main menu background image.
