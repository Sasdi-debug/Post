using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_feladat
{
    public class ImagePost : Post
    {
        private int _imageCount;
        public int ImageCount
        {
            get
            {
                return _imageCount;
            }
            set
            {
                if(value < 1 || value > 10)
                {
                    value = 1;
                }
                else
                {
                    _imageCount = value;
                }
            }
        }
        public ImagePost(string author, int imageCount) : base(author)
        {
            _imageCount = imageCount;
        }
        public override int Score()
        {                           return Likes * 2;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + $"{Author}, {Likes} kedvelés, {ImageCount} kép,";
        }
    }
}
