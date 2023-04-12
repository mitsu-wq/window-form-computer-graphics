namespace lab_10;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.Paint += this.Form1_Paint;
    }

    private void Form1_Paint(object sender, PaintEventArgs e){
        Graphics g = e.Graphics;
        g.Clear(Color.White);

        Pen penBlackSolid = new Pen(Brushes.Black, 2);
        Pen penPinkSolid = new Pen(Brushes.Pink, 2);
        Pen penRedDash = new Pen(Brushes.Red, 2);
        Pen penBlueDashDot = new Pen(Brushes.Blue, 2);
        penRedDash.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        penBlueDashDot.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

        g.DrawLine(penBlackSolid, new Point(10, 10), new Point(100, 100));
        g.DrawLine(penPinkSolid, new Point(400, 400), new Point(300, 200));
        g.DrawLine(penRedDash, new Point(230, 300), new Point(300, 400));
        g.DrawLine(penBlueDashDot, new Point(150, 200), new Point(200, 250));

        Point[] PolygonPoints = {
            new Point(600, 300),
            new Point(700, 400),
            new Point(750, 320),
            new Point(800, 350)
        };
        g.DrawPolygon(penBlueDashDot, PolygonPoints);

        g.DrawEllipse(penRedDash, 100, 50, 80, 40);

        g.DrawRectangle(penBlackSolid, 600, 50, 100, 50);

        Brush brush = new SolidBrush(Color.Black);
        g.FillRectangle(brush, 500, 200, 100, 50);
    }
}
