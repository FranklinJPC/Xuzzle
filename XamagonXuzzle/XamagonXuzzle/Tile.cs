using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamagonXuzzle
{
    public class Tile
    {
        // Diccionario para mapear la fila y columna a los nombres de archivo de las imágenes
        private static readonly Dictionary<string, string> ImageNames = new Dictionary<string, string>
        {
            { "0_0", "uno" }, { "0_1", "dos" }, { "0_2", "tres" }, { "0_3", "cuatro" },
            { "1_0", "cinco" }, { "1_1", "seis" }, { "1_2", "siete" }, { "1_3", "ocho" },
            { "2_0", "nueve" }, { "2_1", "diez" }, { "2_2", "once" }, { "2_3", "doce" },
            { "3_0", "trece" }, { "3_1", "catorce" }, { "3_2", "quince" }, // El último espacio está vacío
        };

        public Tile(int row, int col)
        {
            Row = row;
            Col = col;

            string imageName = ImageNames[$"{row}_{col}"];
            TileView = new ContentView
            {
                Padding = new Thickness(1),
                Content = new Image
                {
                    Source = ImageSource.FromFile($"{imageName}.png")
                }
            };

            // Añadir TileView al diccionario para obtener el Tile a partir del TileView
            Dictionary.Add(TileView, this);
        }

        public static Dictionary<View, Tile> Dictionary { get; } = new Dictionary<View, Tile>();

        public int Row { set; get; }

        public int Col { set; get; }

        public View TileView { private set; get; }
    }
}
