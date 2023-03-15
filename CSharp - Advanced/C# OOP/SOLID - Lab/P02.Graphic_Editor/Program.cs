using P02.Graphic_Editor.Editors;
using P02.Graphic_Editor.Shapes;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            var circle = new Circle();
            var square = new Square();

            var editor = new GraphicEditor();
            editor.DrawShape(circle);
            editor.DrawShape(square);
        }
    }
}
