using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_feladat
{
    public abstract class Post
    {
        private string _author;
        private int _likes;
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }
        public int Likes
        {
            get
            {
                return _likes;
            }
        }
        public Post(string author)
        {
            _likes = 0;
            Author = author;
        }
        public virtual bool Like()
        {
            _likes++;
            return true;
        }
        public virtual string GetDescription()
        {
            return $"";
        }
    }
}
