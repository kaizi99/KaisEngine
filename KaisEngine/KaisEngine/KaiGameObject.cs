using System;
using System.Collections.Generic;
using System.Linq;
/*Copyright 2015 Kai-Uwe Zimdars

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 */
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace KaisEngine
{
    class KaiGameObject : DrawableGameComponent
    {
        public Vector3 position { get; private set; }
        public Vector3 rotation { get; private set; }

        List<KaiGameObject> childObjects { get; private set; }
        KaiGameObject parentObject { get; set; }

        public override void Initialize()
        {
            childObjects = new List<KaiGameObject>();
            position = new Vector3();
            rotation = new Vector3();

            base.Initialize();
        }

        public void attachChildObject(ref KaiGameObject child)
        {
            child.parentObject = this;
            childObjects.Add(child);
        }

        public override void Update(GameTime gameTime)
        {
            if(parentObject != null)
            {
                position += parentObject.position;
                rotation += parentObject.rotation;
            }

            base.Update(gameTime);
        }
    }
}
