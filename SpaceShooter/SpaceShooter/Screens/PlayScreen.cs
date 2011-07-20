using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceShooter
{
    public class PlayScreen:GameScreen
    {
        #region members and prob

        Camera camera;
        List<GameplayObject> gameObjects = new List<GameplayObject>();
        List<GameplayObject> currentGameObjects = new List<GameplayObject>();
        TimeSpan enemySpawnTimer;
        float spawnSeconds, maxSpawnSeconds;
        Player player;
        SpriteFont font;
     
        StarsBackgroundTex stars;

        public static bool gameOver = false;
        public static Viewport view;
        static List<GameplayObject> addedObjects = new List<GameplayObject>();
        public static Texture2D fadeTexture;
        #endregion
        public static string alphaa;
        public static string alphab;
        public static int calcs;
        public static  void AddGameObject(GameplayObject newObject)
        {
            addedObjects.Add(newObject);
        }


        #region ctor inisliazie and load and unload


        public PlayScreen()
        {
            spawnSeconds = 7;
            maxSpawnSeconds = 7;
            enemySpawnTimer = TimeSpan.FromSeconds(spawnSeconds);

            gameOver = false;
            addedObjects.Clear();

            //particle shit
      
        }

        public override void Initialize()
        {
            view = ScreenManager.Viewport;
            fadeTexture = new Texture2D(ScreenManager.GraphicsDevice, 1, 1);
            Color[] c = new Color[] {(Color.Snow)};
            fadeTexture.SetData<Color>(c);
            stars = new StarsBackgroundTex(ScreenManager.GraphicsDevice,
                ScreenManager.GraphicsDevice.PresentationParameters.BackBufferWidth,
                ScreenManager.GraphicsDevice.PresentationParameters.BackBufferHeight, 400);

            camera = new Camera(ScreenManager.GraphicsDevice.Viewport, new Vector2(ScreenManager.GraphicsDevice.Viewport.Width / 2, ScreenManager.GraphicsDevice.Viewport.Height / 2));

        }
        public override void LoadContent()
        {
            ContentManager content = ScreenManager.Content;
            Bullet.bulletTex = content.Load<Texture2D>("Sprites/Bullet"); 
            Player.playerTex =content.Load<Texture2D>("Sprites/PlayerPaper");
            Enemy.enemyTex= content.Load<Texture2D>("Sprites/EnemyPaper");
            font = content.Load<SpriteFont>("Fonts/help");
            player = new Player(ScreenManager.Viewport);
            gameObjects.Add(player);


            //particle shit
            


            //particle shits

             

            //audio shit here

            SFX.StopSong();
            SFX.PlaySong("Media/Music/Oliacym 001 - Electronic");
        }


        public override void UnloadContent()
        {
            Player.playerTex = null;
            Enemy.enemyTex = null;
            Bullet.bulletTex = null;
            font = null;
 
        }

        #endregion

        public void SpawnEnemy()
        {
            spawnSeconds--;
            if (spawnSeconds < 0)
                spawnSeconds = maxSpawnSeconds;

            enemySpawnTimer = TimeSpan.FromSeconds(spawnSeconds);
            gameObjects.Add(Enemy.GenerateEnemy(ScreenManager.Viewport, player));

        }



 
        public override void HandleInput()
        {
            InputSystem input = ScreenManager.InputSystem;
            if (input.MenuCancel)
            {
                ScreenState = ScreenState.Frozen;
                ScreenManager.AddScreen(new PauseScreen(this));
            }
            else
            {
                player.HandleInput(input);
            }
        }


        public override void Update(GameTime gameTime, bool covered)
        {
            if (ScreenState == ScreenState.Active)
            {
                //add new objects wating to the main list
                foreach (GameplayObject gO in addedObjects)
                    gameObjects.Add(gO);

                enemySpawnTimer = enemySpawnTimer.Subtract(gameTime.ElapsedGameTime);

                if (enemySpawnTimer.TotalSeconds <= 0)
                {
                    SpawnEnemy();
                    stars.GenerateNewStars(200);
                }

                CheckCollision();
                addedObjects.Clear();
                currentGameObjects.Clear();

                foreach (GameplayObject gO in gameObjects)
                    currentGameObjects.Add(gO);


                for (int i = 0; i < currentGameObjects.Count; i++)
                {
                    if (currentGameObjects[i].Status == ObjectStatus.Dead)
                    {
                        if (currentGameObjects[i] is Enemy)
                        {
                            SFX.PlayEffect("Media/SFX/squish-01");
                        }
                        gameObjects.Remove(currentGameObjects[i]);
                    }
                    else
                    {
                        currentGameObjects[i].Update(gameTime);
                    }
                }
                if (gameOver)
                {
                    ExitScreen();
                    ScreenManager.AddScreen(new GameOverScreen());
                }

                //camera
                if (ScreenManager.InputSystem.CurrentKeyboardState.IsKeyDown(Keys.B))
                    camera.Shake(0.5f, 5f, 0.005f);

                camera.Update(gameTime, ScreenManager.InputSystem.CurrentKeyboardState, ScreenManager.InputSystem.PreviousKeyboardState);
              
        

            }
            else
                  base.Update(gameTime, covered);
        }


        public void DrawStrings(SpriteBatch spriteBatch)
        {
            Viewport view = ScreenManager.Viewport;

            spriteBatch.DrawString(font, "new enemy in : " +
                enemySpawnTimer.Seconds.ToString(),
                new Vector2(2, 50), Color.White);
            string info = "hits left : " + player.GetHits() + " kills : " +
                player.GetKills() + " calcs : " + calcs + " aa " + alphaa + " ab " + alphab + " ap " ;

            spriteBatch.DrawString(font, info,
                new Vector2(view.Width - font.MeasureString(info).X, 
                    view.Height - font.LineSpacing), Color.Violet);

            
        }


        public override void Draw(GameTime gameTime)
        {
            SpriteBatch spriteBatch = ScreenManager.SpriteBatch;
            Texture2D debugPixel = ScreenManager.Content.Load<Texture2D>("Sprites/debugPixel");


            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, camera.Transform);
          //  spriteBatch.Begin();
            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Draw(gameTime, spriteBatch);
               
                //debugpixels
            //    spriteBatch.Draw(debugPixel, new Rectangle(gameObjects[i].Rectangle.X + gameObjects[i].Texture.Width, gameObjects[i].Rectangle.Y, debugPixel.Width, debugPixel.Height), Color.Black);
              //  spriteBatch.Draw(debugPixel, new Rectangle(gameObjects[i].Rectangle.X, gameObjects[i].Rectangle.Y + gameObjects[i].Texture.Height, debugPixel.Width, debugPixel.Height), Color.Black);
                //spriteBatch.Draw(debugPixel, new Rectangle(gameObjects[i].Rectangle.X + gameObjects[i].Texture.Width, gameObjects[i].Rectangle.Y + gameObjects[i].Texture.Height, debugPixel.Width, debugPixel.Height), Color.Black);
               // spriteBatch.Draw(debugPixel, new Rectangle(gameObjects[i].Rectangle.X, gameObjects[i].Rectangle.Y, debugPixel.Width, debugPixel.Height), Color.Black);           
            }
            
            DrawStrings(spriteBatch);
            spriteBatch.Draw(stars, new Vector2(0, 0),Color.WhiteSmoke);
            if (ScreenState == ScreenState.Frozen)
                FadeScreen(spriteBatch, fadeTexture, Color.PeachPuff, 0.6f);
            // draw particles

            spriteBatch.End();

            
        }


        public void CheckCollision()
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                for (int j = i + 1; j < gameObjects.Count; j++)
                {
                    if ((gameObjects[i].Rectangle.Intersects(gameObjects[j].Rectangle)) &&
                        (gameObjects[i].Status == ObjectStatus.Active) &&
                        (gameObjects[j].Status == ObjectStatus.Active))
                    {
                        if (gameObjects[i] is Player)
                        {
                            SFX.PlayEffect("Media/SFX/snap-shut");
                        }
                        gameObjects[i].Collision(gameObjects[j]);
                    }
                }
            }
        }
    }
}
