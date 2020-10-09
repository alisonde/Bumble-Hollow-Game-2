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
    public class ObjectManager
    {
        public List<GameObject> objects = new List<GameObject>();
        public int Count { get { return objects.Count; } }

        public ObjectManager() { }

        public void Update(GameTime gt, Game1 g)
        {
            for (int i = 0; i < Count; i++)
            {
                GameObject obj = objects[i];

                if (obj.rendered)
                {
                    obj.SetBounds(obj.x, obj.y, obj.width, obj.height);
                    obj.Update(gt, g);
                }
            }
        }

        public void Draw(Game1 g)
        {
            for (int i = 0; i < Count; i++)
            {
                GameObject obj = objects[i];

                if (obj.rendered && obj.visible)
                {
                    obj.Draw(g);
                }
            }

        }

        // sets
        public void Add(GameObject obj, Game1 g) { objects.Add(obj); obj.Init(g); }
        public virtual void Remove(GameObject obj, Game1 g) { obj.Destroy(g); objects.Remove(obj); }
        public virtual void Remove(int index, Game1 g) { objects[index].Destroy(g); objects.Remove(objects[index]); }
        public void Clear() { objects.Clear(); }

        // gets
        public int GetCount() { return Count; }
    }
}
