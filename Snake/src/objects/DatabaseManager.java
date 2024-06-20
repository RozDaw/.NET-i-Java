package objects;

import java.sql.*;

public class DatabaseManager
{
    private static final String DATABASE_URL = "jdbc:sqlite:snakegame.db";

    static {
        try {
            Class.forName("org.sqlite.JDBC");
        } catch (ClassNotFoundException e) {
            System.out.println("SQLite JDBC Driver not found.");
            e.printStackTrace();
        }
    }

    public DatabaseManager() {
        createTable();
    }

    public Connection connect() {
        Connection conn = null;
        try {
            conn = DriverManager.getConnection(DATABASE_URL);
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
        return conn;
    }

    private void createTable() {
        String sql = "CREATE TABLE IF NOT EXISTS scores (\n"
                + " id INTEGER PRIMARY KEY AUTOINCREMENT,\n"
                + " name TEXT NOT NULL,\n"
                + " score INTEGER NOT NULL,\n"
                + " speed INTEGER NOT NULL,\n"
                + " width INTEGER NOT NULL,\n"
                + " height INTEGER NOT NULL\n"
                + ");";
        try (Connection conn = this.connect();
             Statement stmt = conn.createStatement()) {
            stmt.execute(sql);
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
    }

    public void insertScore(String name, int score, int speed, int width, int height) {
        String sql = "INSERT INTO scores(name, score, speed, width, height) VALUES(?, ?, ?, ?, ?)";

        try (Connection conn = this.connect();
             PreparedStatement pstmt = conn.prepareStatement(sql)) {
            pstmt.setString(1, name);
            pstmt.setInt(2, score);
            pstmt.setInt(3, speed);
            pstmt.setInt(4, width);
            pstmt.setInt(5, height);
            pstmt.executeUpdate();
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
    }
}
