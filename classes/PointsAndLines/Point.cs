
namespace PointAndLines
{
    class Point {
        public int x;
        public int X{
            get{
                return x;
            }
            set{
                x = value;
            }
        }
        public int y;
        private int z;
    
        public Point(){
            X = -1; //name it differently
            this.y = -1;
            this.z = -1;
        }
        public Point(int x, int y, int z){
            X = x;
            this.y = y;
            this.z = z;
        }

    }

}
