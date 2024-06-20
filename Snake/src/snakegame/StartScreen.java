package snakegame;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class StartScreen extends JFrame
{
    private JTextField widthField;
    private JTextField heightField;
    private JTextField speedField;
    private JTextField nameField;
    private JButton startButton;
    private GameSettings settings;

    public StartScreen()
    {
        setTitle("Snake Game - Start Screen");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(500, 300);
        setLocationRelativeTo(null);

        ImageIcon icon = new ImageIcon("C:\\Users\\Dawid\\Desktop\\Snake");
        setIconImage(icon.getImage());

        JPanel mainPanel = new JPanel();
        mainPanel.setLayout(new BorderLayout());
        mainPanel.setBorder(BorderFactory.createEmptyBorder(20, 5, 20, 20));

        JLabel titleLabel = new JLabel("Snake Game", SwingConstants.CENTER);
        titleLabel.setFont(new Font("Arial", Font.BOLD, 24));
        mainPanel.add(titleLabel, BorderLayout.NORTH);

        JPanel formPanel = new JPanel();
        formPanel.setLayout(new GridLayout(4, 2, 10, 10));

        formPanel.add(new JLabel("Width:", SwingConstants.LEFT));
        widthField = new JTextField("15");
        formPanel.add(widthField);

        formPanel.add(new JLabel("Height:", SwingConstants.LEFT));
        heightField = new JTextField("15");
        formPanel.add(heightField);

        formPanel.add(new JLabel("Speed: (ticks per second)", SwingConstants.LEFT));
        speedField = new JTextField("5");
        formPanel.add(speedField);

        formPanel.add(new JLabel("Player Name:", SwingConstants.LEFT));
        nameField = new JTextField("anonymous");
        formPanel.add(nameField);

        mainPanel.add(formPanel, BorderLayout.CENTER);

        startButton = new JButton("Start Game");
        startButton.setFont(new Font("Arial", Font.BOLD, 16));
        JPanel buttonPanel = new JPanel();
        buttonPanel.add(startButton);
        mainPanel.add(buttonPanel, BorderLayout.SOUTH);

        add(mainPanel);

        startButton.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                int width = Integer.parseInt(widthField.getText());
                int height = Integer.parseInt(heightField.getText());
                int speed = Integer.parseInt(speedField.getText());
                String playerName = nameField.getText();

                settings = new GameSettings(width, height, speed, playerName);

                dispose(); // zamknij ekran startowy
                SnakeGame.startGame(settings);
            }
        });
    }

    public static void main(String[] args)
    {
        SwingUtilities.invokeLater(new Runnable()
        {
            @Override
            public void run()
            {
                new StartScreen().setVisible(true);
            }
        });
    }
}
