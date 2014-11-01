using OpenTK;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGame
{
    class Player : Entity
    {
        Vector2 velocity;

        public Player(MyGameWindow window)
            : base(window)
        {
            Scale = Vector2.One * 0.1f;
        }

        public override void Update()
        {
            Scale = Vector2.One * 0.1f;
            if (Window.Keyboard[Key.Left])
                velocity.X -= DT * 100;

            if (Window.Keyboard[Key.Right])
                velocity.X += DT * 100;

            if (Window.Keyboard[Key.Up])
                velocity.Y += DT * 100;

            if (Window.Keyboard[Key.Down])
                velocity.Y -= DT * 100;

            velocity.Y -= DT * 9.8f;

            Position += velocity * DT;

            velocity *= 0.9f;
        }
    }
}
