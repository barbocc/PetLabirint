﻿using Microsoft.Xna.Framework; using Microsoft.Xna.Framework.Graphics; using Microsoft.Xna.Framework.Input;  namespace PetLabirint {     /// <summary>     /// This is the main type for your game.     /// </summary>     public class Game1 : Game     {         GraphicsDeviceManager graphics;         SpriteBatch spriteBatch;         private AnimatedSprite animatedSprite;          Texture2D texture;         Texture2D levelTextures;         Vector2 position;         Rectangle drawRec;         LevelGenerator levelGenerator;         float alpha = 1.0f;         float rotation = 0.0f;         Vector2 origin = new Vector2(0, 0);         float scale = 1.0f;         SpriteEffects spriteEffect = SpriteEffects.None;         float zDepth = 0.1f;         Player player;          public Game1()         {             graphics = new GraphicsDeviceManager(this);             Content.RootDirectory = "Content";         }          /// <summary>         /// Allows the game to perform any initialization it needs to before starting to run.         /// This is where it can query for any required services and load any non-graphic         /// related content.  Calling base.Initialize will enumerate through any components         /// and initialize them as well.         /// </summary>         protected override void Initialize()         {             // TODO: Add your initialization logic here              base.Initialize();             Player player = new Player("Тест");         }          /// <summary>         /// LoadContent will be called once per game and is the place to load         /// all of your content.         /// </summary>         protected override void LoadContent()         {             this.IsMouseVisible = true;             // Create a new SpriteBatch, which can be used to draw textures.             spriteBatch = new SpriteBatch(GraphicsDevice);              texture = Content.Load<Texture2D>(@"cat");             levelTextures = Content.Load<Texture2D>(@"woodpattern");             drawRec = new Rectangle(0, 0, texture.Width, texture.Height);             position = new Vector2(0, 0);             levelGenerator = new LevelGenerator(levelTextures);             animatedSprite = new AnimatedSprite(texture, 1, 2);               // TODO: use this.Content to load your game content here         }          /// <summary>         /// UnloadContent will be called once per game and is the place to unload         /// game-specific content.         /// </summary>         protected override void UnloadContent()         {             // TODO: Unload any non ContentManager content here         }          /// <summary>         /// Allows the game to run logic such as updating the world,         /// checking for collisions, gathering input, and playing audio.         /// </summary>         /// <param name="gameTime">Provides a snapshot of timing values.</param>         protected override void Update(GameTime gameTime)         {             if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))                 Exit();              animatedSprite.Update(gameTime.TotalGameTime);              base.Update(gameTime);          }          /// <summary>         /// This is called when the game should draw itself.         /// </summary>         /// <param name="gameTime">Provides a snapshot of timing values.</param>         protected override void Draw(GameTime gameTime)         {             GraphicsDevice.Clear(Color.CornflowerBlue);             levelGenerator.Draw(spriteBatch);             animatedSprite.Draw(spriteBatch, new Vector2(200, 200));             base.Draw(gameTime);         }     } } 