using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace D2KRMG
{
    public class Map
    {
        public int width;
        public int height;

        public Tile[,] normal;
        public Tile[,] special;

        public Map(int _width, int _height)
        {
            width = _width;
            height = _height;

            normal = new Tile[width,height];
            special = new Tile[width,height];
        }

        public void Save()
        {

            short[] data = new short[(width * height * 2) + 2];
            int place = 0;

            data[place] = (short)width;
            place++;
            data[place] = (short)height;
            place++;

            for (int y = 0; y < height; y ++)
            {
                for (int x = 0; x < width; x++)
                {
                    normal[x,y] = Data.GetSandTile(Data.tilesets.Find(t => t.name == "BLOXBASE"));
                    //normal[x, y] = Data.tiles[5];

                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    special[x,y] = new Tile();
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    data[place] = (short)normal[x,y].locationOnTileset.Location;
                    place++;
                    data[place] = (short)special[x, y].locationOnTileset.Location;
                    place++;
                }
            }

            //File.WriteAllBytes("output" + DateTime.Now.ToFileTimeUtc().ToString() + ".map", data);
            WriteShorts(data, "output" + DateTime.Now.ToFileTimeUtc().ToString() + ".map");



        }

        /*
        https://stackoverflow.com/a/224251
        */
        void WriteShorts(short[] values, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    foreach (short value in values)
                    {
                        bw.Write(value);
                    }
                }
            }
        }
    }
}
