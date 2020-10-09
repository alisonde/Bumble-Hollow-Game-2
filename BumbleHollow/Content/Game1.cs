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

    public class Game1 : Game
    {
        // locations
        public LocationManager locMgr = new LocationManager();
        public GameLocation gameLocation = new GameLocation();

        private Texture2D sprite_texture;
        private Vector2 sprite_position;
                    

        public Game1()
        {            
            ScreenManager.Initialize(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // init
            locMgr.Add(gameLocation, this);
            locMgr.Set(gameLocation);

            // window properties
            IsMouseVisible = true;
            IsFixedTimeStep = false;
            Window.Title = ScreenManager.title;
            Window.AllowUserResizing = true;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            ScreenManager.spriteBatch = new SpriteBatch(GraphicsDevice);

            // sprite loading here
            sprite_texture = Content.Load<Texture2D>("Sprites/Box");

            // sprite loading position here
            sprite_position = new Vector2(0, 0);

        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {

            locMgr.Update(gameTime, this);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            ScreenManager.spriteBatch.Begin();
            ScreenManager.spriteBatch.Draw(sprite_texture, sprite_position, Color.White);
            ScreenManager.spriteBatch.End();

            locMgr.Draw(this);            
            base.Draw(gameTime);
        }
    }

    #region REQUIRED PROGRAM CODE - DO NOT DELETE

#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static void Main()
        {
            using (var game = new Game1())
                game.Run();
        }
    }
#endif

    #endregion

}
