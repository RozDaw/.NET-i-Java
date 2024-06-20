package objects;

import snakegame.GameSettings;

public class Apple
{
    public Coord position;

    public Apple(int startX, int startY)
    {
        position = new Coord(startX, startY);
    }

    @SuppressWarnings("static-access")
    public void setRandomPosition(int width, int height)
    {
        position.x = (int) (Math.random() * width);
        position.y = (int) (Math.random() * height);
    }
}
