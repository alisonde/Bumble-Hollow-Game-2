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
    public static class ScreenManager

    {
        // graphics
        public static GraphicsDeviceManager graphics;
        public static SpriteBatch spriteBatch;

        //window
        public static int ScreenWidth { get; private set; }
        public static int ScreenHeight { get; private set; }
        public static string title = "Bumble Holllow: a gothic victorian simulation adventure";
        public static bool VSync { get; private set; } = true;

        // texture
        private static Texture2D rect;

        // init
        public static void Initialize(Game1 g)
        {
            // set screen size
            ScreenWidth = 2280;
            ScreenHeight = 720;

            // init graphics
            graphics = new GraphicsDeviceManager(g)
            {
                PreferredBackBufferWidth = ScreenWidth,
                PreferredBackBufferHeight = ScreenHeight,
                SynchronizeWithVerticalRetrace = VSync,
                IsFullScreen = true
            };
            graphics.ApplyChanges();

            // init spritebatch
            spriteBatch = new SpriteBatch(g.GraphicsDevice);
        }

        // update
        public static void Update(GameTime gt, Game1 g)
        {

        }

        public static void FillRect(Rectangle bounds, Color col, float depth, Game1 g)
        {
            if (rect == null) { rect = new Texture2D(g.GraphicsDevice, 1, 1); }
            rect.SetData(new[] { Color.White });
            spriteBatch.Draw(rect, bounds, null, col, 0, new Vector2(0, 0), SpriteEffects.None, depth);
        }
    }
}
