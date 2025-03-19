package Components;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.*;
import java.io.File;
import javax.imageio.ImageIO;
import java.awt.image.BufferedImage;
import java.util.ArrayList;

// CarouselPanel Component
public class Carousel extends JPanel {
    /**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private JLabel imageLabel;
    private ArrayList<ImageIcon> images;
    private int currentIndex = 0;
    private Timer timer;

    public Carousel(String imagePath) {
        setBackground(new Color(34, 40, 49));
        setLayout(new BorderLayout(0, 0));
        images = loadImages(imagePath);
        imageLabel = new JLabel();
        add(imageLabel);
        if (!images.isEmpty()) {
            imageLabel.setIcon(images.get(0));
            startCarousel();
        }
    }

    private ArrayList<ImageIcon> loadImages(String path) {
        ArrayList<ImageIcon> imageList = new ArrayList<>();
        File folder = new File(path);
        if (folder.exists() && folder.isDirectory()) {
            for (File file : folder.listFiles()) {
                try {
                    BufferedImage img = ImageIO.read(file);
                    imageList.add(new ImageIcon(img.getScaledInstance(380, 380, Image.SCALE_SMOOTH)));
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        }
        return imageList;
    }

    private void startCarousel() {
        timer = new Timer(3000, new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                currentIndex = (currentIndex + 1) % images.size();
                imageLabel.setIcon(images.get(currentIndex));
            }
        });
        timer.start();
    }
}