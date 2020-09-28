using src.main.java.org.teachingextentions.logo.utils.TurtleWindowUtils.ProgramWindow;
using src.main.java.org.teachingextentions.logo.Turtle.Animals;
using src.main.java.org.teachingextentions.logo.utils.ApprovalUtils.general.ObjectUtils;
using src.main.java.org.teachingextentions.logo.utils.LineAndShapeUtils.Paintable;
using src.main.java.org.teachingextentions.logo.utils.PuzzleUtils.Tile;
using javax.swing.Star;
using java.awt.Star;
public class Unicorn : Paintable {
    
    private int x;
    
    private int y;
    
    private Image image;
    
    private int scale;
    
    private Dimension dimension = new Dimension(10, 10);
    
    public Unicorn(int x, int y, int scale) {
        this.x = this.x;
        this.y = this.y;
        this.scale = (this.scale / 10);
        this.image = Unicorn.getImage();
    }
    
    private static Image getImage() {

    // TODO: error here
    //   return ObjectUtils.loadImage(Tile.class, (Animals.Unicorn + ".png"));
    
    }
    
    void AddTo(ProgramWindow programWindow) {
        programWindow.add(this);
    }
    
    [Override()]
    void Paint(Graphics2D g, JPanel caller) {
        g.drawImage(this.image, this.x, this.y, (this.dimension.width * this.scale), (this.dimension.height * this.scale), null);
    }
}

