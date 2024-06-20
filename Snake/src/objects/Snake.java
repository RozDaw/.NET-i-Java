package objects;

import snakegame.SnakeGame;

public class Snake
{
    SnakeGame main;

    public String direction;
    public int length;

    public Coord[] snake = new Coord[1000000];

    //Constructor
    public Snake(int x0, int y0, int x1, int y1)
    {
        snake[0] = new Coord(x0, y0);
        snake[1] = new Coord(x1, y1);

        length = 2;
        direction = "right";
    }



    @SuppressWarnings("static-access")
    public boolean move(boolean ate, int width, int height)
    {
        if(ate)    snake[length] = new Coord(snake[length-1].x, snake[length-1].y);

        //Moving Snakes tail
        for (int i=length-1; i>0; i--)
        {
            snake[i].x = snake[i-1].x;
            snake[i].y = snake[i-1].y;
        }

        //Moving Snakes head
        if (direction.equals("right"))  snake[0].x++;
        if (direction.equals("up"))     snake[0].y--;
        if (direction.equals("left"))   snake[0].x--;
        if (direction.equals("down"))   snake[0].y++;

        if(ate)    length++;

        //If left map
        if (snake[0].x >= width || snake[0].x < 0 || snake[0].y >= height || snake[0].y < 0)        return true;

        //If hit himself
        for(int i=1; i<length; i++)
            if(snake[0].x == snake[i].x && snake[0].y == snake[i].y)
                return true;

        return false;
    }


    public String toString()
    {
        String answer = "";
        for(int i=0; i<length; i++)
        {
            answer += "[" + i + "] " + snake[i].x + " " + snake[i].y + "\t";
        }
        return answer;
    }
}