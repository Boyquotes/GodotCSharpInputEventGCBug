using Godot;
using System;

public class mouse_move : Node
{
    public override void _Input(InputEvent ev)
    {
        if (ev is InputEventMouse)
        {
            var i = 4 + 4;
        }
    }
}
