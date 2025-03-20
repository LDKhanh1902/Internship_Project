package Components;

import javax.swing.*;
import javax.swing.tree.*;
import java.awt.*;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.HashMap;

public class DropDownMenu extends JTree {
	private static final long serialVersionUID = 1L;
	private HashMap<String, Runnable> optionEventMap = new HashMap<>(); // Sự kiện cho Mục con (Loại 2)

	public DropDownMenu() {
		super(createTreeModel());
		setRootVisible(false);
		setShowsRootHandles(true);
		setToggleClickCount(1);
		setShowsRootHandles(false);
		setRowHeight(30);
		setBorder(BorderFactory.createEmptyBorder(5, 5, 5, 5));
		setCellRenderer(new DefaultTreeCellRenderer() {
			private static final long serialVersionUID = 1L;
			private final ImageIcon homeIcon = ImageIconHelper.setSizeImage("/resource/images/logo.png", 20, 20);
			private final ImageIcon productIcon = ImageIconHelper.setSizeImage("/resource/images/money_bag.png", 20,
					20);
			private final ImageIcon invoiceIcon = ImageIconHelper.setSizeImage("/resource/images/money_bag.png", 20,
					20);

			@Override
			public Component getTreeCellRendererComponent(JTree tree, Object value, boolean selected, boolean expanded,
					boolean leaf, int row, boolean hasFocus) {
				JLabel label = (JLabel) super.getTreeCellRendererComponent(tree, value, selected, expanded, leaf, row,
						hasFocus);
				label.setFont(new Font("Arial", Font.BOLD, 16));

				String nodeName = value.toString();

				switch (nodeName) {
				case "Trang Chủ":
					label.setIcon(homeIcon);
					break;
				case "Hàng hóa":
					label.setIcon(productIcon);
					break;
				case "Nhân viên":
					label.setIcon(invoiceIcon);
					break;
				case "Doanh mục thuế":
					label.setIcon(invoiceIcon);
					break;
				case "Hóa đơn":
					label.setIcon(invoiceIcon);
					break;
				case "Tài khoản":
					label.setIcon(invoiceIcon);
					break;
				default:
					label.setIcon(null);
				}
				return label;
			}
		});

		// 🎯 Khai báo sự kiện cho Menu và Mục con
		setupEventHandlers();

		// 🎯 Thêm sự kiện click vào node menu
		addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				TreePath path = getPathForLocation(e.getX(), e.getY());
				if (path != null) {
					DefaultMutableTreeNode selectedNode = (DefaultMutableTreeNode) path.getLastPathComponent();
					String nodeName = selectedNode.getUserObject().toString();

					if (selectedNode.isLeaf()) {
						// 🔥 Xử lý sự kiện của Mục con (Loại 2)
						if (optionEventMap.containsKey(nodeName)) {
							optionEventMap.get(nodeName).run();
						}
					}
				}
			}
		});
	}

	private static TreeModel createTreeModel() {
		DefaultMutableTreeNode root = new DefaultMutableTreeNode("Root");
		DefaultMutableTreeNode menu1 = new DefaultMutableTreeNode("Trang Chủ");
		DefaultMutableTreeNode menu2 = new DefaultMutableTreeNode("Hàng hóa");
		DefaultMutableTreeNode menu3 = new DefaultMutableTreeNode("Nhân viên");
		DefaultMutableTreeNode menu4 = new DefaultMutableTreeNode("Doanh mục thuế");
		DefaultMutableTreeNode menu5 = new DefaultMutableTreeNode("Hóa đơn");
		DefaultMutableTreeNode menu6 = new DefaultMutableTreeNode("Tài khoản");

		DefaultMutableTreeNode option1 = new DefaultMutableTreeNode("Option 1");
		DefaultMutableTreeNode option2 = new DefaultMutableTreeNode("Option 2");
		DefaultMutableTreeNode option3 = new DefaultMutableTreeNode("Option 3");

		menu1.add(option1);
		menu1.add(option2);
		menu2.add(option3);

		root.add(menu1);
		root.add(menu2);
		root.add(menu3);
		root.add(menu4);
		root.add(menu5);
		root.add(menu6);
		return new DefaultTreeModel(root);
	}

	private void setupEventHandlers() {
		// 🔥 Gán sự kiện cho Mục con (Loại 2)
		optionEventMap.put("Option 1", () -> JOptionPane.showMessageDialog(null, "Bạn đã chọn Option 1!"));
		optionEventMap.put("Option 2", () -> JOptionPane.showMessageDialog(null, "Bạn đã chọn Option 2!"));
		optionEventMap.put("Option 3", () -> JOptionPane.showMessageDialog(null, "Bạn đã chọn Option 3!"));
	}
}
