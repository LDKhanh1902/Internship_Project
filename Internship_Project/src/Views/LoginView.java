package Views;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.*;

import Components.Carousel;

public class LoginView extends JFrame {

    private static final long serialVersionUID = 1L;

    public LoginView() {
        setTitle("Modern Login UI");
        setSize(800, 400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null);
        setUndecorated(true);
        setLayout(new BorderLayout());

        JPanel mainPanel = new JPanel(new GridLayout(1, 2));

        // Left Panel - Introduction
        JPanel leftPanel = new JPanel();
        leftPanel.setLayout(new BorderLayout(0, 0));
        leftPanel.add(new Carousel("src/resource/images/"));

        // Right Panel - Login Form
        JPanel rightPanel = new JPanel(new GridBagLayout());
        rightPanel.setBackground(new Color(34, 40, 49));
        rightPanel.setBorder(BorderFactory.createEmptyBorder(20, 20, 20, 20));
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.insets = new Insets(10, 10, 10, 10);
        gbc.fill = GridBagConstraints.HORIZONTAL;

        JLabel titleLabel = new JLabel("Đăng Nhập", SwingConstants.CENTER);
        titleLabel.setFont(new Font("Arial", Font.BOLD, 24));
        titleLabel.setForeground(Color.WHITE);
        gbc.gridx = 0;
        gbc.gridy = 0;
        gbc.gridwidth = 2;
        rightPanel.add(titleLabel, gbc);

        JLabel userLabel = new JLabel("Tên đăng nhập:");
        userLabel.setForeground(Color.WHITE);
        JTextField userField = new JTextField(15);
        gbc.gridy = 1;
        gbc.gridwidth = 1;
        rightPanel.add(userLabel, gbc);
        gbc.gridx = 1;
        rightPanel.add(userField, gbc);

        JLabel passLabel = new JLabel("Mật khẩu:");
        passLabel.setForeground(Color.WHITE);
        JPasswordField passField = new JPasswordField(15);
        gbc.gridx = 0;
        gbc.gridy = 2;
        rightPanel.add(passLabel, gbc);
        gbc.gridx = 1;
        rightPanel.add(passField, gbc);

        JCheckBox showPassword = new JCheckBox("Hiện mật khẩu");
        showPassword.setForeground(Color.WHITE);
        showPassword.setBackground(new Color(34, 40, 49));
        showPassword.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (showPassword.isSelected()) {
                    passField.setEchoChar((char) 0);
                } else {
                    passField.setEchoChar('*');
                }
            }
        });
        gbc.gridx = 1;
        gbc.gridy = 3;
        rightPanel.add(showPassword, gbc);

        JButton loginButton = new JButton("Đăng nhập");
        loginButton.setBackground(new Color(0, 173, 181));
        loginButton.setForeground(Color.WHITE);
        loginButton.setFont(new Font("Arial", Font.BOLD, 16));
        loginButton.setBorderPainted(false);
        loginButton.setFocusPainted(false);
        gbc.gridx = 0;
        gbc.gridy = 4;
        gbc.gridwidth = 2;
        rightPanel.add(loginButton, gbc);

        // Close Button
        JButton closeButton = new JButton("X");
        closeButton.setForeground(Color.WHITE);
        closeButton.setBackground(new Color(255, 69, 58));
        closeButton.setBorderPainted(false);
        closeButton.setFocusPainted(false);
        closeButton.setFont(new Font("Arial", Font.BOLD, 14));
        closeButton.addActionListener(e -> System.exit(0));
        JPanel topPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        topPanel.setBackground(new Color(34, 40, 49));
        topPanel.add(closeButton);
        
        mainPanel.add(leftPanel);
        mainPanel.add(rightPanel);

        add(topPanel, BorderLayout.NORTH);
        add(mainPanel, BorderLayout.CENTER);
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            new LoginView().setVisible(true);
        });
    }
}
