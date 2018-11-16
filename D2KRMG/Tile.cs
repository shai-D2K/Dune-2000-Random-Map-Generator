using System;
using System.Collections.Generic;
using System.Text;

namespace D2KRMG
{
    public class Tile
    {
        public readonly Tileset tileset;
        public readonly NormalSpecial classification;
        
        public readonly PositionType type;
        public readonly NormalTileType normalType;
        public readonly SpecialTileType specialType;
        public readonly TileLocation locationOnTileset;
        public readonly string name;

        public Tile(Tileset _tileset, NormalSpecial _classification, PositionType _type, NormalTileType _normalType, SpecialTileType _specialType, TileLocation _locationOnTileset, string _name)
        {
            tileset = _tileset;
            classification = _classification;
            type = _type;
            specialType = _specialType;
            normalType = _normalType;
            locationOnTileset = _locationOnTileset;
            name = _name;
        }

        public Tile()
        {
            locationOnTileset = new TileLocation(0);
        }
    }
}
