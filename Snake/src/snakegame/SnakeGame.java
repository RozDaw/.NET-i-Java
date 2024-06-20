package snakegame;

import objects.Apple;
import objects.Snake;
import objects.DatabaseManager;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

public class SnakeGame extends JPanel implements ActionListener
{
    public static final int SCALE = 32;
    public static int WIDTH;
    public static int HEIGHT;
    public static int SPEED;

    Apple apple;
    Snake snake;
    Timer timer;

    private DatabaseManager dbManager = new DatabaseManager();
    private String playerName;

    static JFrame f;

    private Color color(int red, int green, int blue) {return new Color(red, green, blue);}

    public SnakeGame(GameSettings settings)
    {
        WIDTH = settings.width;
        HEIGHT = settings.height;
        SPEED = settings.speed;
        playerName = settings.playerName;

        apple = new Apple((int) (Math.random() * WIDTH), (int) (Math.random() * HEIGHT));
        snake = new Snake(WIDTH/2, HEIGHT/2, WIDTH/2-1, HEIGHT/2);
        timer = new Timer(1000 / SPEED, this);

        timer.start();
        addKeyListener(new Keyboard());
        setFocusable(true);
    }

    public void paint(Graphics g)
    {
        g.setColor(color(5, 50, 10)); // Background color
        g.fillRect(0, 0, WIDTH * SCALE, HEIGHT * SCALE);
        g.setColor(color(255, 216, 0)); // Grid color

        //Drawing vertical lines
        for (int xx = 0; xx <= WIDTH * SCALE; xx += SCALE)      g.drawLine(xx, 0, xx, HEIGHT * SCALE);

        //Drawing horizontal lines
        for (int yy = 0; yy <= HEIGHT * SCALE; yy += SCALE)     g.drawLine(0, yy, WIDTH * SCALE, yy);

        //Drawing snakes tail
        for (int i = 1; i < snake.length; i++)
        {
            g.setColor(color(0, 0, 255));
            g.fillRect(snake.snake[i].x * SCALE + 1, snake.snake[i].y * SCALE + 1, SCALE - 1, SCALE - 1);
        }

        //Drawing snakes head
        g.setColor(color(255, 255, 255));
        g.fillRect(snake.snake[0].x * SCALE + 1, snake.snake[0].y * SCALE + 1, SCALE - 1, SCALE - 1);

        //Drawing apple
        g.setColor(color(255, 0, 0));
        g.fillRect(apple.position.x * SCALE + 1, apple.position.y * SCALE + 1, SCALE - 1, SCALE - 1);
    }

    public static void startGame(GameSettings settings)
    {
        f = new JFrame();
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        f.setResizable(false);
        f.setSize(settings.width * SCALE + 19, settings.height * SCALE + 48);
        f.setLocationRelativeTo(null);      //by default in the center of screen
        f.add(new SnakeGame(settings));
        f.setVisible(true);
        f.setTitle("Score: 0");
    }

    public static void main(String[] args) {StartScreen.main(args);}

    public void actionPerformed(ActionEvent e)
    {
        f.setTitle("Score: " + snake.length);
        boolean collision = false;

        if ((snake.snake[0].x == apple.position.x) & (snake.snake[0].y == apple.position.y))
        {
            apple.setRandomPosition(WIDTH, HEIGHT);
            collision = snake.move(true, WIDTH, HEIGHT);
        }
        else  collision = snake.move(false, WIDTH, HEIGHT);


        for (int k = 1; k < snake.length; k++)
            if ((snake.snake[k].x == apple.position.x) & (snake.snake[k].y == apple.position.y))
                apple.setRandomPosition(WIDTH, HEIGHT);

        repaint();

        if (collision)
        {
            timer.stop();
            dbManager.insertScore(playerName, snake.length, SPEED, WIDTH, HEIGHT);
            EndScreen endScreen = new EndScreen();
            endScreen.setVisible(true);
        }

    }


    private class Keyboard extends KeyAdapter
    {
        public void keyPressed(KeyEvent kEve)
        {
            int key = kEve.getKeyCode();
            if ((key == KeyEvent.VK_RIGHT) & !snake.direction.equals("left"))             snake.direction = "right";
            if ((key == KeyEvent.VK_DOWN) & !snake.direction.equals("up"))                snake.direction = "down";
            if ((key == KeyEvent.VK_LEFT) & !snake.direction.equals("right"))             snake.direction = "left";
            if ((key == KeyEvent.VK_UP) & !snake.direction.equals("down"))                snake.direction = "up";
        }
    }
}
