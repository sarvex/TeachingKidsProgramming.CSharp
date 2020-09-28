using src.main.java.org.teachingextentions.logo.utils.TurtleWindowUtils.ProgramWindow;
using src.main.java.org.teachingextentions.logo.Turtle.Animals;
using src.main.java.org.teachingextentions.logo.utils.ApprovalUtils.general.ObjectUtils;
using src.main.java.org.teachingextentions.logo.utils.LineAndShapeUtils.Paintable;
using src.main.java.org.teachingextentions.logo.utils.PuzzleUtils.Tile;
using javax.swing.Star;
using java.awt.Star;

/// <img src="http://vignette2.wikia.nocookie.net/farmville/images/0/06/Sweet_Dreams_Unicorn-icon.png/revision/latest/scale-to-width/100?cb=20130802132644" style="text-align: left" alt="Unicorns are magical - like programming!"height=35 width=35 >
/// The Unicorn lets you add Unicorns (rather than Turtles!) to your window
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

   /// <summary> Adds a Unicorn to the Program Window.  
   /// <example>
   ///  <code>  
   ///      Unicorn.addTo(programWindow)}
   ///  </code>
   /// </example>
   ///  <param>
   ///      programWindow 
   ///      is the current Program Window
   ///  </param>
   /// </summary>
    void AddTo(ProgramWindow programWindow) {
        programWindow.add(this);
    }
    
    [Override()]
    void Paint(Graphics2D g, JPanel caller) {
        g.drawImage(this.image, this.x, this.y, (this.dimension.width * this.scale), (this.dimension.height * this.scale), null);
    }
}

