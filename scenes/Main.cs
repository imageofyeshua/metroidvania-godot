using Godot;
using System;

public class Main : Node2D
{
    private Sprite _icon;

    public override void _Ready()
    {
        _icon = GetNode<Sprite>("Sprite");
    }

    public override void _Process(float delta)
    {
        _icon.Position += new Vector2(3, 0);
        if (_icon.Position.x > 800)
        {
            _icon.Position = new Vector2(-50, 300);
        }
    }
}
