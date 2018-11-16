using System;
using System.Collections.Generic;
using System.Text;

namespace D2KRMG
{
    public class Preset
    {
        public readonly Tileset tileset;
        

        public readonly int width = 0;
        public readonly int height = 0;

        public readonly Tile[][] tiles;


        public Preset(Tileset _tileset, int _width, int _height, Tile[][] _tiles)
        {
            tileset = _tileset;
            width = _width;
            height = _height;
            tiles = _tiles;
        }
    }
}
