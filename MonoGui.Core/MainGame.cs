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
    public static SpriteBatch SpriteBatch { get; private set; }
    public static MainGame Instance { get; private set; }

    public MainGame()
    {
        Graphics = new GraphicsDeviceManager(this);
        Graphics.PreferredBackBufferHeight = 900;
        Graphics.PreferredBackBufferWidth  = 1600;
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        Instance = this;
    }

    protected override void Initialize()
    {
        TextureManager.Init();
        ScreenManager.Add(new TestScreen());
        ScreenManager.Add(new MainMenuScreen());

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
        GraphicsDevice.Clear(Color.Black);

        SpriteBatch.Begin();

        ScreenManager.Draw(gameTime);

        SpriteBatch.End();

        base.Draw(gameTime);
    }
}
