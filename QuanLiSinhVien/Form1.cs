using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace QuanLiSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MakeRoundedPanel(panelAcc, 20);
            MakeRoundedPanel(panelPass, 20);
            MakeRoundedButton(btnLog, 20);
            MakeRoundedButton(btnExit, 20);

            // Cho ứng dụng chính giữa khi mở app
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        // Hàm bo tròn panel
        public static void MakeRoundedPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = new Rectangle(0, 0, panel.Width, panel.Height);
            int diameter = radius * 2;

            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90); // Top-left
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90); // Top-right
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-right
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-left
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        // Hàm bo tròn button
        public static void MakeRoundedButton(Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = new Rectangle(0, 0, button.Width, button.Height);
            int diameter = radius * 2;

            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90); // top-left
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90); // top-right
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90); // bottom-right
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90); // bottom-left
            path.CloseFigure();

            button.Region = new Region(path);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
