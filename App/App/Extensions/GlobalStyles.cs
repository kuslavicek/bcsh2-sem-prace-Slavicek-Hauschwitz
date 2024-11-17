using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

public static class GlobalStyles
{
    public static void ApplyButtonStyle(Button button,bool tab=false)
    {
        button.Font = SystemFonts.IconTitleFont;

        button.FlatStyle = FlatStyle.Standard;
        button.BackColor = Application.RenderWithVisualStyles ? Color.Azure : SystemColors.Control;
        button.ForeColor = Color.Black;
        button.Padding = new Padding(5);

        if (tab)
        {
            button.Size = new Size(370, 40);
        }
        else {
            button.Size = new Size(100, 40);
        }

        button.MouseEnter += (sender, e) =>
        {
            button.BackColor = Color.LightBlue;
        };

        button.MouseLeave += (sender, e) =>
        {
            button.BackColor = Application.RenderWithVisualStyles ? Color.Azure : SystemColors.Control;
        };
    }
}
