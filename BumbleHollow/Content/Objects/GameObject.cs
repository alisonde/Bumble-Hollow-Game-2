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
    public abstract class GameObject
    {
        public float x, y;
        public float xSpeed, ySpeed;
        public float moveX, moveY;
        public int width, height;
        public Vector2 Position { get { return new Vector2(x, y); } set { x = value.X; y = value.Y; } }    
        public Vector2 Speed { get { return new Vector2(xSpeed, ySpeed); }  set { xSpeed = value.X; ySpeed = value.Y; } }
        public Vector2 Size { get { return new Vector2(width, height); } set { width = (int)value.X; height = (int)value.Y; } }
        public Rectangle bounds;

        // properties
        public int id;
        public string text, tag;
        public bool rendered, visible;
        public bool collision, hover;

        // sprite
        public Vector2 spritePOS;

        public GameObject(int x, int y, int w, int h, int id)
        {
            // dimensions
            this.x = x;
            this.y = y;
            this.width = w;
            this.height = h;
            bounds = new Rectangle(x, y, width, height);

            // properties
            this.id = id;
            rendered = true;
            visible = true;
            collision = false;
            hover = false;
            spritePOS = new Vector2(0, 0);

        }

        // abstracts
        public abstract void Init(Game1 g);
        public abstract void Destroy(Game1 g);
        public abstract void Update(GameTime gt, Game1 g);
        public abstract void Draw(Game1 g);

        // sets
        public void SetPosition(float x, float y) { this.x = x; this.y = y; }
        public void SetSpeed(float xs, float ys) { this.xSpeed = x; this.ySpeed = y; }
        public void SetSize(int w, int h) { this.width = w; this.height = h; }
        public void SetBounds(float x, float y, int w, int h) { this.bounds = new Rectangle((int) x, (int) y, width, height); }

        // gets
        public int GetID() { return id; }
        public float DistanceTo(Vector2 pos) { return Vector2.Distance(Position, pos); }
        public Vector2 GetPositionCentered() { return new Vector2(x = (width / 2), y = (height / 2)); }




    }
}
