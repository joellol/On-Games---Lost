
using System;
using System.Collections.Generic;
using GXPEngine;

public class MyGame : Game
{
    public List<GameObject> WallList = new List<GameObject>();
    static public int xSize;
    static public int YSize;
	SoundChannel musicChannel;

    public MyGame() : base(1920, 1080, false)
	{
        Levelbuilder builder = new Levelbuilder();
        xSize = width / 32;
        YSize = height / 18;
        levelOne();
	}

	void Update()
	{
		
	}

	static void Main()
	{
		new MyGame().Start();					
	}
    public void levelOne()
    {
		Sound music = new Sound("Music.mp3", true, true);
		{
			musicChannel = music.Play();
		}
		Ground ground = new Ground();
		AddChild(ground);
        for(int i = 0; i < 33; i++)
        {
            WallList.Add(new Wall());
            AddChild(WallList[WallList.Count - 1]);
            WallList[WallList.Count - 1].x = (game.width / 32) * i;
        }
        for (int i = 1; i < 33; i++)
        {
            WallList.Add(new Wall());
            AddChild(WallList[WallList.Count - 1]);
            WallList[WallList.Count - 1].x = (game.width / 32) * i;
            WallList[WallList.Count - 1].y = (game.height / 18) * 17;
        }
        for (int i = 1; i < 19; i++)
        {
            WallList.Add(new Wall());
            AddChild(WallList[WallList.Count - 1]);
            WallList[WallList.Count - 1].y = (game.height / 18) * i;
        }
        for (int i = 1; i < 18; i++)
        {
            WallList.Add(new Wall());
            AddChild(WallList[WallList.Count - 1]);
            WallList[WallList.Count - 1].y = (game.height / 18) * i;
            WallList[WallList.Count - 1].x = (game.width / 32) * 31;
        }
        Player player = new Player();
        AddChild(player);
        player.gameManager = this;
    }
}