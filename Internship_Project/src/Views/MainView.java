package Views;

import javax.swing.*;
import java.awt.*;

import Components.Carousel;
import Components.DropDownMenu;

public class MainView extends JFrame {
	private JPanel mainView;
	
    public MainView() {
        setTitle("Dashboard");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(800, 500);
        setLocationRelativeTo(null); // Căn giữa cửa sổ
        getContentPane().setLayout(new BorderLayout());

        // 💠 Giao diện hệ thống
        try {
            UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
            SwingUtilities.updateComponentTreeUI(this);
        } catch (Exception e) {
            e.printStackTrace();
        }

        // 🌟 Sidebar (Menu bên trái)
        JPanel sidebar = new JPanel(new BorderLayout());
        sidebar.setPreferredSize(new Dimension(200, 500));
        sidebar.setBackground(new Color(50, 60, 80)); // Màu xanh đậm
        sidebar.setBorder(BorderFactory.createEmptyBorder(0, 0, 0, 0));

        // 👉 Thêm DropDownMenu vào Sidebar
        JScrollPane menuScrollPane = new JScrollPane(new DropDownMenu());
        menuScrollPane.setBorder(null); // Loại bỏ viền
        sidebar.add(menuScrollPane, BorderLayout.CENTER);

        // 🌟 Main View (Khu vực chính)
        mainView = new JPanel();
        mainView.setBackground(new Color(245, 245, 245)); // Màu xám nhạt
        mainView.setBorder(BorderFactory.createEmptyBorder(0, 0, 0, 0));
        mainView.setLayout(new BorderLayout(0, 0));

        // 🌟 Gộp tất cả vào Frame
        getContentPane().add(sidebar, BorderLayout.WEST);
        getContentPane().add(mainView, BorderLayout.CENTER);
        
        showContent(new Carousel("src/resource/images/"));
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            new MainView().setVisible(true);
        });
    }
    
    public void showContent(JPanel content) {
    	this.mainView.removeAll();
    	this.mainView.add(content);
    	this.repaint();
    }
}
