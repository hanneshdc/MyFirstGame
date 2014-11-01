using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using OpenTK.Input;

namespace MyFirstGame
{
    class MyGameWindow : GameWindow
    {
        Entity entityList = null;
        Renderer renderer;

        Entity player;
        Level currentLevel;

        const float DT = 1 / 60f;

        

        public void AddEntity(Entity entity)
        {
            if (entityList != null)
                entityList.prev = entity;
            entity.next = entityList;
            entityList = entity;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(Color4.CornflowerBlue);
            renderer = new Renderer(this);

            player = new Player(this);
            currentLevel = new Level(this, "level2.bmp");
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            foreach (Entity entity in entityList)
                entity.Update();
            
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            renderer.Draw(entityList);

            SwapBuffers();
        }
    }
}
