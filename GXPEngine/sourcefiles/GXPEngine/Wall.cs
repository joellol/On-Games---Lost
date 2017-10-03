using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;

class Wall : Sprite
{
    public float xPos;
    public float yPos;
    public Wall() : base("Wall.png")
    {
        width = MyGame.xSize;
        height = MyGame.YSize;
        xPos = this.x;
        yPos = this.y;

    } 
}
