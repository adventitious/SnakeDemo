using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace snakeDemo
{

    /// https://www.wpf-tutorial.com/creating-game-snakewpf/creating-the-game-area/

    public class SnakePart
    {
        public UIElement UiElement { get; set; }

        public Point Position { get; set; }

        public bool IsHead { get; set; }
    }
}
