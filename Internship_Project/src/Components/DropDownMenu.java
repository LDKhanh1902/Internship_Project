package Components;

import javax.swing.*;
import javax.swing.tree.*;
import java.awt.*;

//Lớp DropdownMenu kế thừa JTree
public class DropDownMenu extends JTree {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	public DropDownMenu() {
		super(createTreeModel());
		setRootVisible(false);
		setShowsRootHandles(true);
		setToggleClickCount(1); // Chỉnh thành 1 click để mở menu
		setBorder(BorderFactory.createEmptyBorder(5, 5, 5, 5)); // Tạo lề 5px xung quanh
		setCellRenderer(new DefaultTreeCellRenderer() {
			/**
			 * 
			 */
			private static final long serialVersionUID = 1L;

			@Override
			public Component getTreeCellRendererComponent(JTree tree, Object value, boolean selected, boolean expanded,
					boolean leaf, int row, boolean hasFocus) {
				Component c = super.getTreeCellRendererComponent(tree, value, selected, expanded, leaf, row, hasFocus);
				setIcon(null); // Xóa icon
				return c;
			}
		});
		setShowsRootHandles(false);
	}

	private static TreeModel createTreeModel() {
		DefaultMutableTreeNode root = new DefaultMutableTreeNode("Root");
		DefaultMutableTreeNode menu1 = new DefaultMutableTreeNode("Menu 1");
		DefaultMutableTreeNode menu2 = new DefaultMutableTreeNode("Menu 2");
		menu1.add(new DefaultMutableTreeNode("Option 1"));
		menu1.add(new DefaultMutableTreeNode("Option 2"));
		menu2.add(new DefaultMutableTreeNode("Option 3"));
		root.add(menu1);
		root.add(menu2);
		return new DefaultTreeModel(root);
	}
}