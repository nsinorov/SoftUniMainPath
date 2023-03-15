using System;
using P02.Graphic_Editor.Interfaces;
using P02.Graphic_Editor.Shapes;

namespace P02.Graphic_Editor.Editors
{
    public class GraphicEditor
    {
        public void DrawShape(IShape shape) => Console.WriteLine(shape.Draw());
    }
}
