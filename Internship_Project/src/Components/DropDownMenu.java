package Components;

import javax.swing.*;
import javax.swing.tree.*;
import java.awt.*;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

public class DropDownMenu extends JTree {
    private static final long serialVersionUID = 1L;
    private Carousel carousel; // Tham chiếu đến Carousel

    public DropDownMenu(Carousel carousel) {
        super(createTreeModel());
        this.carousel = carousel; // Gán carousel để cập nhật ảnh khi chọn menu
        setRootVisible(false);
        setShowsRootHandles(true);
        setToggleClickCount(1);
        setBorder(BorderFactory.createEmptyBorder(5, 5, 5, 5));

        setCellRenderer(new DefaultTreeCellRenderer() {
            private static final long serialVersionUID = 1L;
            @Override
            public Component getTreeCellRendererComponent(JTree tree, Object value, boolean selected, boolean expanded,
                                                          boolean leaf, int row, boolean hasFocus) {
                Component c = super.getTreeCellRendererComponent(tree, value, selected, expanded, leaf, row, hasFocus);
                setIcon(null);
                return c;
            }
        });

        // Thêm sự kiện click vào menu
        addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                TreePath path = getPathForLocation(e.getX(), e.getY());
                if (path != null) {
                    DefaultMutableTreeNode selectedNode = (DefaultMutableTreeNode) path.getLastPathComponent();
                    String nodeName = selectedNode.getUserObject().toString();
                    System.out.println("Clicked on: " + nodeName);
                    
                    // Gọi hàm đổi ảnh theo menu
                    switch (nodeName) {
                        case "Menu 1":
                            JOptionPane.showMessageDialog(carousel, "1");
                            break;
                        case "Menu 2":
                        	JOptionPane.showMessageDialog(carousel, "2");
                            break;
                        case "Option 1":
                        	JOptionPane.showMessageDialog(carousel, "3");
                            break;
                        case "Option 2":
                        	JOptionPane.showMessageDialog(carousel, "4");
                            break;
                        default:
                            break;
                    }
                }
            }
        });
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
