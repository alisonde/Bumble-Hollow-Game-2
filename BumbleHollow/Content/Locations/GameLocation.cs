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
    public class GameLocation : Location
    {
        public ObjectManager objMgr = new ObjectManager();
        Player player = new Player(128, 128);
        Obj_Block block = new Obj_Block(50, 128);

        public GameLocation() : base(PageID.game)
        {

        }

        public override void Init(Game1 g)
        {
            objMgr.Add(player, g);
            objMgr.Add(block, g);
        }

        public override void Update(GameTime gt, Game1 g)
        {
            objMgr.Update(gt, g);
        }

        public override void Draw(Game1 g)
        {
            // REMOVED THIS CODE TO CORRECT NOT DISPLAYING BOX.PNG -> g.GraphicsDevice.Clear(Color.Turquoise);

            // begin
            ScreenManager.spriteBatch.Begin();
            //  objs
            objMgr.Draw(g);
            // end
            ScreenManager.spriteBatch.End();

        }

    }
}
