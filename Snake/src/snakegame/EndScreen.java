package snakegame;

import objects.DatabaseManager;
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class EndScreen extends JFrame {
    private JLabel endMessageLabel;
    private JButton replayButton;
    private JButton exitButton;
    private JTextArea scoresArea;
    private DatabaseManager dbManager = new DatabaseManager();

    public EndScreen() {
        setTitle("Snake Game - End Screen");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(600, 500);
        setLocationRelativeTo(null);

        JPanel mainPanel = new JPanel(new BorderLayout());
        mainPanel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));

        endMessageLabel = new JLabel("End of game!");
        endMessageLabel.setFont(new Font("Arial", Font.BOLD, 24));
        endMessageLabel.setHorizontalAlignment(SwingConstants.CENTER);
        mainPanel.add(endMessageLabel, BorderLayout.NORTH);

        scoresArea = new JTextArea();
        scoresArea.setFont(new Font("Monospaced", Font.PLAIN, 14));
        scoresArea.setEditable(false);
        scoresArea.setMargin(new Insets(10, 10, 10, 10));
        JScrollPane scrollPane = new JScrollPane(scoresArea);
        mainPanel.add(scrollPane, BorderLayout.CENTER);
        displayScores();

        JPanel buttonPanel = new JPanel(new GridLayout(1, 2, 20, 10));
        replayButton = new JButton("Replay");
        replayButton.setFont(new Font("Arial", Font.BOLD, 18));
        replayButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                dispose(); // Zamknij ekran końcowy
                String[] args = new String[0];
                StartScreen.main(args);
            }
        });
        buttonPanel.add(replayButton);

        exitButton = new JButton("Exit");
        exitButton.setFont(new Font("Arial", Font.BOLD, 18));
        exitButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                System.exit(0); // Zamknij aplikację
            }
        });
        buttonPanel.add(exitButton);

        mainPanel.add(buttonPanel, BorderLayout.SOUTH);

        add(mainPanel);
    }

    private void displayScores() {
        String sql = "SELECT name, score, speed, width, height FROM scores ORDER BY score DESC";
        try (Connection conn = dbManager.connect();
             Statement stmt = conn.createStatement();
             ResultSet rs = stmt.executeQuery(sql)) {
            StringBuilder scoresText = new StringBuilder();
            scoresText.append(String.format("%-20s %-10s %-10s %-10s %-10s\n", "Name", "Score", "Speed", "Width", "Height"));
            scoresText.append("---------------------------------------------------------------\n");
            while (rs.next()) {
                scoresText.append(String.format("%-20s %-10d %-10d %-10d %-10d\n",
                        rs.getString("name"),
                        rs.getInt("score"),
                        rs.getInt("speed"),
                        rs.getInt("width"),
                        rs.getInt("height")));
            }
            scoresArea.setText(scoresText.toString());
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(new Runnable() {
            @Override
            public void run() {
                new EndScreen().setVisible(true);
            }
        });
    }
}
