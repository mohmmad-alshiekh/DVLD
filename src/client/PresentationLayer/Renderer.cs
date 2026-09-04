using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public class Renderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected) 
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(51,51,51)), e.Item.ContentRectangle);
                e.Item.ForeColor = Color.White; 
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(64,64,64)), e.Item.ContentRectangle); 
                e.Item.ForeColor = Color.White;
            }
        }
    }
}
