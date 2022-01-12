using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystic_Audio
{
    public class Song
    {
        
        
        public int ID { get; set; }
        string album;
        string artists;
        Image image;
        string name;
        string title;
        string filepath;
        string genre;
        string year;
        string duration;
        public Song()
        {
            

        }
        public Song(string path)
        {
            FilePath = path;
            
        }
        public string Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
        public string Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }
        public string FilePath
        {
            get
            {
                return filepath;
            }
            set
            {
                filepath = value;
            }
        }
        public string Album
        {
            get
            {
                return album;
            }
            set
            {
                album = value;
            }
        }

        public string Artists
        {
            get
            {
                return artists;
            }
            set
            {
                artists = value;
            }
        }

        public Image CoverArt
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

    }
}
