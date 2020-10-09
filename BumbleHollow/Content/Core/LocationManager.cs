using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Design;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace BumbleHollow
{
    public class LocationManager
    {
        public List<Location> locations = new List<Location>();
        public int Count { get { return locations.Count; } }
        public int selected;

        public void Update(GameTime gt, Game1 g)
        {
            for (int i = 0; i < Count; i++)
            {
                Location location = locations[i];
                if (location.id == selected) { location.Update(gt, g); }
            }
        }

        public void Draw(Game1 g)
        {
            for (int i = 0; i < Count; i++)
            {
                Location location = locations[i];
                if (location.id == selected) { location.Draw(g); }
            }
        }

        public virtual void Set(int id) { selected = id; }
        public virtual void Set(Location location) { selected = location.id; }

        public void Add(Location location, Game1 g) { locations.Add(location); location.Init(g); }
        public void Remove(Location location) { locations.Remove(location); }
        public void Clear() { locations.Clear(); }
    }
}
