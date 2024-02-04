using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uMap2Bitmap.Entities
{
    public enum PageCaptureType
    {
        Jpeg = 0,
        Png = 1,
        Webp = 2
    }

    public enum PathType
    {
        File = 0,
        Directory = 1,
        Unknown = 2
    }

    public enum PropertiesType
    {
        Layers = 0,
        Polygons = 1
    }

    public enum ViewType
    {
        DragDrop = 0,
        Main = 1,
        Settings = 2
    }

    public enum StringRepeatType
    {
        Replace = 0,
        Concat = 1,
        SBInsert = 2,
        SBAppendJoin = 3
    }
}
