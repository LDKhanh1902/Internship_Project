package Views;

import javax.swing.*;

import Components.DropDownMenu;

import java.awt.*;

//Lớp MainView tạo giao diện chính
public class MainView extends JFrame {
	
	public MainView() {
			setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
			setSize(600, 400);
			try {
				UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName()); // Sử dụng giao diện hệ thống
				SwingUtilities.updateComponentTreeUI(this); // Cập nhật lại giao diện của frame
			} catch (Exception e) {
				e.printStackTrace();
			}

			JPanel mainPanel = new JPanel(new BorderLayout());
			JPanel sidebar = new JPanel(new BorderLayout());
			sidebar.setPreferredSize(new Dimension(150, 400));
			sidebar.add(new JScrollPane(new DropDownMenu()), BorderLayout.CENTER);

			JPanel topPanel = new JPanel();
			topPanel.setPreferredSize(new Dimension(450, 50));
			topPanel.add(new JLabel("STATUS OR TOOL IN MAINVIEW"));

			JPanel mainView = new JPanel();
			mainView.setLayout(new BorderLayout(0, 0));
			mainView.add(new JLabel("MAIN VIEW"));

			JPanel rightPanel = new JPanel(new BorderLayout());
			rightPanel.add(topPanel, BorderLayout.NORTH);
			rightPanel.add(mainView, BorderLayout.CENTER);

			mainPanel.add(sidebar, BorderLayout.WEST);
			mainPanel.add(rightPanel, BorderLayout.CENTER);

			getContentPane().add(mainPanel);
	}
}
