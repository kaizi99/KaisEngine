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
using System;
using System.Collections.Generic;
using System.Linq;
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
    class PlayerModel : KaiGameObject
    {
        Dictionary<Dictionary<Vector3, Model>, Effect> models;

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Draw(GameTime gameTime)
        {
            foreach (KeyValuePair<Dictionary<Vector3, Model>, Effect> modelPart in models)
            {
                foreach(KeyValuePair<Vector3, Model> model in modelPart.Key)
                {

                }
            }
            base.Draw(gameTime);
        }

    }
}
