using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGui.Core.GUI;
using MonoGui.Core.Managers;
using MonoGui.Core.Screens;
namespace MonoGui.Core;

public class MainGame : Game
{
    public static GraphicsDeviceManager Graphics { get; private set; }
    public static SpriteBatch SpriteBatchGame { get; private set; }
    public static SpriteBatch SpriteBatchUI { get; private set; }
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
        SettingsManager.Init();

        Camera.Init();
        
        base.Initialize();
    }

    protected override void LoadContent()
    {
        SpriteBatchGame = new SpriteBatch(GraphicsDevice);
        SpriteBatchUI = new SpriteBatch(GraphicsDevice);


        ScreenManager.Push(new TestScreen(SpriteBatchGame));
        //ScreenManager.Push(new MainMenuScreen(SpriteBatchGame));
    }

    protected override void Update(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        InputManager.Update();

        Camera.Update();

        ScreenManager.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);

        SpriteBatchGame.Begin(SpriteSortMode.Deferred, null, null, null, null, null, Camera.Transform);
        SpriteBatchUI.Begin();

        ScreenManager.Draw();

        SpriteBatchGame.End();
        SpriteBatchUI.End();

        base.Draw(gameTime);
    }
}
