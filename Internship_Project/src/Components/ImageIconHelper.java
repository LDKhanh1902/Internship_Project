package Components;
import java.awt.Image;

import javax.swing.ImageIcon;

public class ImageIconHelper {
	public static ImageIcon setSizeImage(String url) {
    	ImageIcon icon = new ImageIcon(ImageIconHelper.class.getResource(url));
        Image img = icon.getImage();
        Image scaledImg = img.getScaledInstance(50, 50, Image.SCALE_SMOOTH);
        ImageIcon scaledIcon = new ImageIcon(scaledImg);
        return scaledIcon;
    }
	
	public static ImageIcon setSizeImage(String url, int width, int height) {
	    ImageIcon icon = new ImageIcon(ImageIconHelper.class.getResource(url)); // Lấy icon từ URL
	    Image img = icon.getImage(); // Lấy đối tượng Image từ ImageIcon
	    Image scaledImg = img.getScaledInstance(width, height, Image.SCALE_SMOOTH); // Thay đổi kích thước
	    ImageIcon scaledIcon = new ImageIcon(scaledImg); // Tạo ImageIcon từ hình đã thay đổi kích thước
	    return scaledIcon;
	}
}
