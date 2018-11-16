using System;
using System.Collections.Generic;
using System.Text;

namespace D2KRMG
{
    public static class Data
    {

        public static List<Tileset> tilesets;
        public static List<Tile> tiles;
        public static List<Preset> presets;

        static Data()
        {
            tilesets = new List<Tileset>();
            tilesets.Add((new Tileset("BLOXBASE")));
            tilesets.Add((new Tileset("BLOXBAT")));
            tilesets.Add((new Tileset("BLOXBGBS")));
            tilesets.Add((new Tileset("BLOXICE")));
            tilesets.Add((new Tileset("BLOXTREE")));
            tilesets.Add((new Tileset("BLOXWAST")));
            tilesets.Add((new Tileset("BLOXXMAS")));

            tiles = new List<Tile>();
            tiles.Add((new Tile(tilesets.Find(x => x.name == "BLOXBASE"), NormalSpecial.Normal, PositionType.Main, NormalTileType.OtherMain, SpecialTileType.None, (new TileLocation(0)), "northRockCliff001Main")));
            tiles.Add((new Tile(tilesets.Find(x => x.name == "BLOXBASE"), NormalSpecial.Normal, PositionType.Extra, NormalTileType.OtherMain, SpecialTileType.None, (new TileLocation(0)), "northRockCliff001Extra1")));
            tiles.Add((new Tile(tilesets.Find(x => x.name == "BLOXBASE"), NormalSpecial.Normal, PositionType.Extra, NormalTileType.OtherMain, SpecialTileType.None, (new TileLocation(0)), "northRockCliff001Extra2")));
            tiles.Add((new Tile(tilesets.Find(x => x.name == "BLOXBASE"), NormalSpecial.Normal, PositionType.Extra, NormalTileType.OtherMain, SpecialTileType.None, (new TileLocation(0)), "northRockCliff001Extra3")));

            tiles.Add((new Tile(tilesets.Find(x => x.name == "BLOXBASE"), NormalSpecial.Normal, PositionType.Main, NormalTileType.Sand, SpecialTileType.None, (new TileLocation(48)), "sand01")));
            tiles.Add((new Tile(tilesets.Find(x => x.name == "BLOXBASE"), NormalSpecial.Normal, PositionType.Main, NormalTileType.Sand, SpecialTileType.None, (new TileLocation(49)), "sand02")));
            tiles.Add((new Tile(tilesets.Find(x => x.name == "BLOXBASE"), NormalSpecial.Normal, PositionType.Main, NormalTileType.Sand, SpecialTileType.None, (new TileLocation(50)), "sand03")));
            tiles.Add((new Tile(tilesets.Find(x => x.name == "BLOXBASE"), NormalSpecial.Normal, PositionType.Main, NormalTileType.Sand, SpecialTileType.None, (new TileLocation(51)), "sand04")));
            tiles.Add((new Tile(tilesets.Find(x => x.name == "BLOXBASE"), NormalSpecial.Normal, PositionType.Main, NormalTileType.Sand, SpecialTileType.None, (new TileLocation(52)), "sand05")));
            tiles.Add((new Tile(tilesets.Find(x => x.name == "BLOXBASE"), NormalSpecial.Normal, PositionType.Main, NormalTileType.Sand, SpecialTileType.None, (new TileLocation(68)), "sand06")));
            tiles.Add((new Tile(tilesets.Find(x => x.name == "BLOXBASE"), NormalSpecial.Normal, PositionType.Main, NormalTileType.Sand, SpecialTileType.None, (new TileLocation(69)), "sand07")));
            tiles.Add((new Tile(tilesets.Find(x => x.name == "BLOXBASE"), NormalSpecial.Normal, PositionType.Main, NormalTileType.Sand, SpecialTileType.None, (new TileLocation(70)), "sand08")));
            tiles.Add((new Tile(tilesets.Find(x => x.name == "BLOXBASE"), NormalSpecial.Normal, PositionType.Main, NormalTileType.Sand, SpecialTileType.None, (new TileLocation(71)), "sand09")));
            tiles.Add((new Tile(tilesets.Find(x => x.name == "BLOXBASE"), NormalSpecial.Normal, PositionType.Main, NormalTileType.Sand, SpecialTileType.None, (new TileLocation(72)), "sand10")));

            tiles.Add((new Tile(tilesets.Find(x => x.name == "BLOXBASE"), NormalSpecial.Normal, PositionType.Main, NormalTileType.Rock, SpecialTileType.None, (new TileLocation(552)), "rock01")));
            tiles.Add((new Tile(tilesets.Find(x => x.name == "BLOXBASE"), NormalSpecial.Normal, PositionType.Main, NormalTileType.Rock, SpecialTileType.None, (new TileLocation(553)), "rock02")));

        }

        public static Tile GetSandTile(Tileset tileset)
        {
            return tiles.FindAll(x => (x.normalType == NormalTileType.Sand) && (x.tileset == tileset)).PickRandom();
        }

        public static Tile GetRockTile(Tileset tileset)
        {
            return tiles.FindAll(x => (x.normalType == NormalTileType.Rock) && (x.tileset == tileset)).PickRandom();
        }


    }
}
