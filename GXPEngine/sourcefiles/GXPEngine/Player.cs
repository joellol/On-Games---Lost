using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;

public class Player : Sprite
{
	private int cooldown = 0;
	Sound step;
	int speed = 10;
	public MyGame gameManager;
	private float _speed = 1280.0f;

	public Player() : base("Player.png")
	{
		width = MyGame.xSize;
		height = MyGame.YSize;

		SetOrigin(width / 2, height / 2);
		x = game.width / 2;
		y = game.height / 2;

		step = new Sound("step.wav");

	}
	public void Update()
	{
		Movement();
	}
	void Movement()
	{
		float deltaTime = Time.deltaTime * 0.01f;

		if (Input.GetKey(Key.W) || Input.GetKey(Key.UP))
		{
			if (cooldown < 1)
			{
				cooldown = 25;
				step.Play();
                tryMove(0, -_speed* deltaTime);
			}
			//this.y -= speed;
		//	if (CollisionCheck() == true)
			//{
			//	this.y += speed;
			//}
		}
		if (Input.GetKey(Key.S) || Input.GetKey(Key.DOWN))
		{
			if (cooldown < 1)
			{
				cooldown = 25;
				step.Play();
				tryMove(0, -_speed * deltaTime);
			}
			//this.y += speed;
			//if (CollisionCheck() == true)
			//{
			//	this.y -= speed;
			//}
		}
		if (Input.GetKey(Key.A) || Input.GetKey(Key.LEFT))
		{
			if (cooldown < 1)
			{
				cooldown = 25;
				step.Play();
                tryMove(0, -_speed* deltaTime);
			}
			//this.x -= speed;
			//if (CollisionCheck() == true)
			//{
			//	this.x += speed;
			//}
		}
		if (Input.GetKey(Key.D) || Input.GetKey(Key.RIGHT))
		{
			if (cooldown < 1)
			{
				cooldown = 25;
				step.Play();
                tryMove(0, -_speed* deltaTime);
			}
			//this.x += speed;
			//if (CollisionCheck() == true)
			//{
			//	this.x -= speed;
			//}
		}
		if (cooldown > 0)
		{
			cooldown--;
		}
	}
	//public bool CollisionCheck()
	//{
	//	for (int i = 0; i < gameManager.WallList.Count; i++)
	//	{
	//		//Console.WriteLine(gameManager.WallList[i].x);

	//		if (gameManager.WallList[i].x < (this.x + this.width) && this.x < gameManager.WallList[i].x + (MyGame.xSize / 32) &&
	//			gameManager.WallList[i].y < (this.y + this.height) && this.y < gameManager.WallList[i].y + (MyGame.YSize / 18))
	//		{
	//			Console.WriteLine("col");
	//			return true;
	//		}
	//	}
	//	return false;
	//}
	private void tryMove(float moveX, float moveY)
	{
		x = x + moveX;
		y = y + moveY;
		foreach (GameObject other in GetCollisions())
		{
			if (other is Wall)
			{
				x = x - moveX;
				y = y - moveY;
                Console.WriteLine(other);
				Console.WriteLine("hi wall");
				return;
			}
		}
	}
}
