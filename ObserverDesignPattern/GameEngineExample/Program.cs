// Client

using GameEngineExample;

Player player = new();

player.Attach(new GameOverScreen(player));
player.Attach(new ScoreUI(player));
player.Attach(new HealthBarUI(player));

player.SetState(100, 0);
player.SetState(100, 10);
player.SetState(80, 20);
player.SetState(10, 30);
player.SetState(0, 30);