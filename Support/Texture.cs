﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace MyGame.Support
{
    public class Texture
    {
        Texture2D image;
        public Vector2 Position;
        public Vector2 size;
        public bool IsPressedRight = false;
        public bool IsPressedLeft = false;
        public bool IsPressedDown = false;
        public bool IsPressedUp = false;

        public Texture(String image, Vector2 position, Vector2 size)
        {
            this.image = Game1.sContent.Load<Texture2D>(image);
            this.Position = position;
            this.size = size;
        }

        public Vector2 MinBound { get => Position - (size * 0.5f); }
        public Vector2 MaxBound { get => Position + (size * 0.5f); }



        public void Draw()
        {
            Rectangle destRect = Camera.ScreenRectangle(Position, size);
            Game1.sSpriteBatch.Draw(image, destRect, Color.White);
        }

        public bool Collides(Texture other)
        {
            Vector2 v = Position - other.Position;
            float dist = v.Length();
            return (dist < ((size.X / 2) + (other.size.X / 2)));
        }
    }
}
