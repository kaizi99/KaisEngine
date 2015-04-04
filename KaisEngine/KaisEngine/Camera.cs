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
    class Camera : GameComponent
    {
        public Vector3 position { get; private set; }
        public Vector3 target { get; private set; }

        public Matrix projection;
        public Matrix viewMatrix;

        private static int cameraDistanceToPlayer = 10;

        private Player playerToTrack;

        public override void Initialize()
        {
            position = new Vector3(0, cameraDistanceToPlayer, 0);
            target = new Vector3(0, 0, 0);
            projection = Matrix.CreateOrthographic(Game.GraphicsDevice.Viewport.Width, Game.GraphicsDevice.Viewport.Height, 0f, 10000f);
            viewMatrix = Matrix.CreateLookAt(position, target, new Vector3(0, 1, 0));
 	        base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            Vector3 newPosition = new Vector3(playerToTrack.position.X, playerToTrack.position.Y, playerToTrack.position.Z + cameraDistanceToPlayer);
            position = newPosition;
            viewMatrix = Matrix.CreateLookAt(position, target, new Vector3(0, 1, 0));
 	        base.Update(gameTime);
        }

        public void setPlayer(ref Player playerToTrack)
        {
            this.playerToTrack = playerToTrack;
        }
    }
}
