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
    public abstract class Location
    {
        public int id;

        public Location(int id)
        {
            this.id = id;
        }

        public abstract void Init(Game1 g);
        public abstract void Update(GameTime gt, Game1 g);
        public abstract void Draw(Game1 g);


    }
}
