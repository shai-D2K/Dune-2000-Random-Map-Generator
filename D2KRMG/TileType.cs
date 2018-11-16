using System;
using System.Collections.Generic;
using System.Text;

namespace D2KRMG
{
    /*
    
        OtherMain - The top left tile of a preset
        OtherExtra - The other tiles in a preset, all clearly idetified

    */
    public enum NormalTileType { None, Sand, Rock, OtherMain, OtherExtra};
    public enum SpecialTileType {None, Spawn, Spice, SandBloomStandard };
    public enum NormalSpecial { Normal, Special };

    public enum PositionType { Main, Extra };
}
