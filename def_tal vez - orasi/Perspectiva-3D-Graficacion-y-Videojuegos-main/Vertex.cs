
namespace Graphic_Engine
{
    
    public class Vertex
    {
        float xVer, yVer, zVer;
        public Vertex(float xLoc, float yLoc, float zLoc)
        {
            this.xVer = xLoc;
            this.yVer = yLoc;
            this.zVer = zLoc;
        }

        public float X
        {
            get 
            { 
                return xVer; 
            }
            set 
            { 
                xVer = value; 
            }
        }

        public float Y
        {
            get
            {
                return yVer;
            }
            set
            {
                yVer = value;
            }
        }

        public float Z
        {
            get
            {
                return zVer;
            }
            set
            {
                zVer = value;
            }
        }
    }


}