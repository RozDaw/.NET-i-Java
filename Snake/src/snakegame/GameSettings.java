package snakegame;

public class GameSettings
{
    public int width;
    public int height;
    public int speed;
    public String playerName;

    public GameSettings(int width, int height, int speed, String playerName)
    {
        this.width = width;
        this.height = height;
        this.playerName = playerName;
        this.speed = speed;
    }
}
