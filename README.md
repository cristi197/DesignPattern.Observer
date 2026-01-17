# Observer Design Pattern

## Overview
The Observer pattern allows objects to subscribe to state changes of another object. When the subject's state changes, all attached observers are notified automatically.

## How It Works
1. **Subject**: Maintains a list of observers and notifies them when its state changes
2. **Observer**: Listens for updates from the subject and responds to state changes
3. **Attach/Detach**: Observers can subscribe or unsubscribe from the subject

## Examples

### First Example
A simple implementation showing basic subject-observer communication:
- **Subject** (`ConcreteSubject`): Holds state and notifies observers when it changes
- **Observer** (`ConcreteObserver`): Receives update notifications

### Game Engine Example
A practical game scenario demonstrating the pattern:
- **Subject** (`Player`): Tracks health and score values
- **Observers**: 
  - `HealthBarUI`: Updates health display
  - `ScoreUI`: Updates score display
  - `GameOverScreen`: Triggers game over when health reaches zero

When the player's health or score changes, all UI elements update automatically.

## Key Benefits
- **Loose Coupling**: Subjects and observers are independent
- **Real-time Updates**: Changes propagate immediately
- **Scalability**: Easy to add new observers

## Project Structure
```
FirstExample/          - Basic subject-observer implementation
GameEngineExample/     - Game UI update scenario
```