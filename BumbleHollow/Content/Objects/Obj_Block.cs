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
    public class Obj_Block : GameObject
    {
        public Obj_Block(int x, int y) : base(x, y, 64, 64, ObjectID.block)
        {
        
        }

        public override void Init(Game1 g)
        {
        }

        public override void Destroy(Game1 g)
        {
        }

        public override void Update(GameTime gt, Game1 g)
        {

        }

        public override void Draw(Game1 g)
        {
            ScreenManager.FillRect(bounds, Color.Red, 0, g);
        }
    }
}
