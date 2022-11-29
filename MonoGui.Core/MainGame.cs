using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGui.Core.GUI;
using MonoGui.Core.Managers;
using MonoGui.Core.Screens;
using MonoGui.Core.Settings;

namespace MonoGui.Core;

public class MainGame : Game
{
    public static GraphicsDeviceManager Graphics { get; private set; }
    public static SpriteBatch SpriteBatch;

    public MainGame()
    {
        Graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        TextureManager.Init();
        ScreenManager.Add(new TestScreen());

        base.Initialize();
    }

    protected override void LoadContent()
    {
        SpriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        ScreenManager.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        SpriteBatch.Begin();

        ScreenManager.Draw(gameTime);

        SpriteBatch.End();

        base.Draw(gameTime);
    }
}
