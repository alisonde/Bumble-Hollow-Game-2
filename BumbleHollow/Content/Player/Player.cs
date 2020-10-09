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
    public class Player : GameObject
    {
        #region Movement Variables
        // input
        KeyboardState kb;

        // speeds
        public float wSpeed = 1;    // Walk Speed
        public float nSpeed = 2;    // Normal Speed
        public float rSpeed = 6;    // Run Speed

#endregion

        public Player(int x, int y) : base(x, y, 50, 50, 0)
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
            #region Movement
            // input
            kb = Keyboard.GetState();
            MovementInput((Game1)g);

            // move
            x += xSpeed;
            y += ySpeed;
            moveX = 0;
            moveY = 0;

            #endregion

        }

        public override void Draw(Game1 g)
        {
            ScreenManager.FillRect(bounds, Color.White, 0, g);
        }
        
        private void MovementInput(Game1 g)
        {
            #region Movement
            // pressed
            if (kb.IsKeyDown(Keys.W)) { ySpeed = -nSpeed; }  // up
            if (kb.IsKeyDown(Keys.S)) { ySpeed = nSpeed; }   // down
            if (kb.IsKeyDown(Keys.A)) { xSpeed = -nSpeed; }  // left
            if (kb.IsKeyDown(Keys.D)) { xSpeed = nSpeed; }   // right

            // alter speed
            if (kb.IsKeyDown(Keys.LeftControl) && kb.IsKeyDown(Keys.W)) { ySpeed = -wSpeed; }    // walk up
            if (kb.IsKeyDown(Keys.LeftControl) && kb.IsKeyDown(Keys.S)) { ySpeed = wSpeed; }    // walk down
            if (kb.IsKeyDown(Keys.LeftControl) && kb.IsKeyDown(Keys.A)) { xSpeed = -wSpeed; }    // walk left
            if (kb.IsKeyDown(Keys.LeftControl) && kb.IsKeyDown(Keys.D)) { xSpeed = wSpeed; }    // walk right
            if (kb.IsKeyDown(Keys.LeftShift) && kb.IsKeyDown(Keys.W)) { ySpeed = -rSpeed; }      // run up
            if (kb.IsKeyDown(Keys.LeftShift) && kb.IsKeyDown(Keys.S)) { ySpeed = rSpeed; }      // run down
            if (kb.IsKeyDown(Keys.LeftShift) && kb.IsKeyDown(Keys.A)) { xSpeed = -rSpeed; }      // run left
            if (kb.IsKeyDown(Keys.LeftShift) && kb.IsKeyDown(Keys.D)) { xSpeed = rSpeed; }      // run right


            // conflicting pressed
            if (kb.IsKeyDown(Keys.W) && kb.IsKeyDown(Keys.S)) { ySpeed = 0; }
            if (kb.IsKeyDown(Keys.A) && kb.IsKeyDown(Keys.D)) { xSpeed = 0; }

            // released
            if (kb.IsKeyUp(Keys.W) && kb.IsKeyUp(Keys.S)) { ySpeed = 0; }
            if (kb.IsKeyUp(Keys.A) && kb.IsKeyUp(Keys.D)) { xSpeed = 0; }

            // ----------  COLLISION CHECK  ----------


            #endregion


        }


    }
}
